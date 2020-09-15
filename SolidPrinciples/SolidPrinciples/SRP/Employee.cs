using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.SRP
{
    public class Employee
    {
        private IFileLogger _fileLogger;

        public Employee(IFileLogger fileLogger)
        {
            _fileLogger = fileLogger;
        }

        public void Add()
        {
            try
            {
                // Add the employee details to the database
            }
            catch (Exception ex)
            {

                File.WriteAllText(@"D:\Error.log", ex.ToString());
            }
        }

        // This breaks SRP as the Add method handles writing the employee to the database but also deals with the logging if there is an error
        // To fix this we need to do the below
        public void Add2()
        {
            try
            {
                // Add the employee details to the database
            }
            catch (Exception ex)
            {
                _fileLogger.Log(@"D:\Error.log", ex.Message);
            }
        }

        // This now fits the SRP principle as the Add2 method calls the fileLogger rather than doing the logging logic itself
        // We can freely update the logging logic without changing this class
    }
}


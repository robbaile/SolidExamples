using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DependencyInjection
{
    public class Employee
    {
        private ILogger _logger;

        public Employee(ILogger logger)
        {
            _logger = logger;
        }

        public void AddEmployee()
        {
            // Can use our abstracted out method in this class 
            _logger.Log("Added Employee");
        }
    }
}

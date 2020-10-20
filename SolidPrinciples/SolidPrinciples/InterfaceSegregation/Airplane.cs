using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregation
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}

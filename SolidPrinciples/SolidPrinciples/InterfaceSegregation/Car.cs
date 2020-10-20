using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregation
{
    // Breaks interface segregation as it does not implement the methods of the interface - instead make an ICar and IPlane
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

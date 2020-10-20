using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClosed
{
    public class Dog : Animal
    {
        public override int NoOfLegs()
        {
            return 4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClosed
{
    public class Human : Animal
    {
        public override int NoOfLegs()
        {
            return 2;
        }
    }
}

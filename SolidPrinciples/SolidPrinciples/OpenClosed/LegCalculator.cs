using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClosed
{
    // Usual method to use is the shape method with rectangles, circles and triangles
    public class LegCalculator
    {
        public int Calculate(object[] animals)
        {
            var numberOfLegs = 0;

            foreach(var animal in animals)
            {
                // Every time we have a different animal, we have to add another if and so we have to 'modify' the class
                if (animal is Spider)
                {
                    numberOfLegs += 8;
                }

                if (animal is Dog)
                {
                    numberOfLegs += 4;
                }

                if (animal is Human)
                {
                    numberOfLegs += 2;
                }
            }

            return numberOfLegs;
        }

        public int Calculate(Animal[] animals)
        {
            // now regardless of animal, we can calculate how many legs they have
            var numberOfLegs = 0;

            foreach (var animal in animals)
            {
                numberOfLegs += animal.NoOfLegs();
            }

            return numberOfLegs;
        }
    }
}

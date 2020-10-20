using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Liskov
{
    public class Bike : IBike
    {
        private bool _isRiding;

        public void Ride()
        {
            _isRiding = true;
        }

        public bool IsRiding { get { return _isRiding; } }
    }
}

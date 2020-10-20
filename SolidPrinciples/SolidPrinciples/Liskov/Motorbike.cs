using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Liskov
{
    public class Motorbike : IBike
    {
        private bool _isRiding;
        private bool _isEngineRunning;

        public void Ride()
        {
            // This will break Liskov rule as the engine much
            if(_isEngineRunning)
            {
                _isRiding = true;
            }

            _isRiding = false;
        }

        public bool IsRiding { get { return _isRiding; } }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Liskov
{
    interface IBike
    {
        public void Ride();

        public bool IsRiding { get; }
    }
}

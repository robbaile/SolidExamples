using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DependencyInjection
{
    public interface ILogger
    {
        public void Log(string message);
    }
}

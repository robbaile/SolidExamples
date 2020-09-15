using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SRP
{
    public interface IFileLogger
    {
        public void Log(string path, string message);
    }
}

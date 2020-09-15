using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.SRP
{
    public class FileLogger : IFileLogger
    {
        public string Path { get; set; }

        public void Log(string path, string message)
        {
            File.WriteAllText(path, message);
        }
    }
}

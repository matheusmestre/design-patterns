using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Target
{
    public class Logger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            Console.WriteLine(message);
        }
    }
}

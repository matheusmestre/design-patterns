using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Adaptee
{
    public class MyCustomLogService
    {
        public void CustomLogInfo(string message)
        {
            Console.WriteLine("Custom Log Info: " + message);
        }
        public void CustomLogWarn(string message)
        {
            Console.WriteLine("Custom Log Warn: " + message);
        }
    }
}

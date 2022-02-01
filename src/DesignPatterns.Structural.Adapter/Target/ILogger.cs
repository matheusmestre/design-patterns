using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Target
{
    public interface ILogger
    {
        void Info(string message);
        void Warn(string message);
    }
}

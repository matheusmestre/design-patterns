using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Adapter
{
    public class LogServiceAdapter: ILogger
    {
        private readonly MyCustomLogService _customLogService;
        public LogServiceAdapter()
        {
            //instanciate or get by DI
            _customLogService = new MyCustomLogService();
        }

        public void Info(string message)
        {
            _customLogService.CustomLogInfo(message);
        }

        public void Warn(string message)
        {
            _customLogService.CustomLogWarn(message);
        }
    }
}

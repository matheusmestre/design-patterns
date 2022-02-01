using DesignPatterns.Structural.Adapter.Adapter;
using DesignPatterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Client
{
    public static class AdapterExecutor
    {
        public static void Execute()
        {
            ILogger logger = new Logger();
            logger.Info("Logging an info!");
            logger.Warn("Logging an warning!");

            ILogger loggerAdapter = new LogServiceAdapter();
            loggerAdapter.Info("Logging an info!");
            loggerAdapter.Warn("Logging an warning!");
        }
    }
}

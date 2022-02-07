using DesignPatterns.Behavorial.Command.Command;
using DesignPatterns.Behavorial.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Command.ConcreteCommand
{
    public class FlipDownCommand : ICommand
    {
        private readonly Lamp _lamp;
        public FlipDownCommand(Lamp lamp)
        {
            _lamp = lamp;
        }
        public void Execute()
        {
            _lamp.TurnOff();
        }
    }
}

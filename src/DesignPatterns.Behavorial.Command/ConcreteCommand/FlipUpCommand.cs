using DesignPatterns.Behavorial.Command.Command;
using DesignPatterns.Behavorial.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Command.ConcreteCommand
{
    public class FlipUpCommand : ICommand
    {
        private readonly Lamp _lamp;
        public FlipUpCommand(Lamp lamp)
        {
            _lamp = lamp;
        }
        public void Execute()
        {
            _lamp.TurnOn();
        }
    }
}

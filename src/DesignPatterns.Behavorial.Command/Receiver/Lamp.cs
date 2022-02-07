using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Command.Receiver
{
    public class Lamp
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp TurnedOn");
        }
        public void TurnOff()
        {
            Console.WriteLine("Lamp TurnedOff");
        }
    }
}
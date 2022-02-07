using DesignPatterns.Behavorial.Command.Command;
using DesignPatterns.Behavorial.Command.ConcreteCommand;
using DesignPatterns.Behavorial.Command.Invoker;
using DesignPatterns.Behavorial.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Command.Client
{
    public class CommandExecutor
    {
        public static void Execute()
        {
            var lamp = new Lamp();

            ICommand cmd1 = new FlipUpCommand(lamp);
            ICommand cmd2 = new FlipDownCommand(lamp);
            ICommand cmd3 = new FlipUpCommand(lamp);
            ICommand cmd4 = new FlipUpCommand(lamp);
            ICommand cmd5 = new FlipDownCommand(lamp);
            ICommand cmd6 = new FlipDownCommand(lamp);

            var @switch = new Switch();

            @switch.StoreAndExecute(cmd1);
            @switch.StoreAndExecute(cmd2);
            @switch.StoreAndExecute(cmd3);
            @switch.StoreAndExecute(cmd4);
            @switch.StoreAndExecute(cmd5);
            @switch.StoreAndExecute(cmd6);

            @switch.Undo(6);
            @switch.Redo(2);
        }
    }
}

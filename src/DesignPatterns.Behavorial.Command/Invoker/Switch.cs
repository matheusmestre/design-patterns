using DesignPatterns.Behavorial.Command.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Command.Invoker
{
    public class Switch
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        private int _current = 0;
        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
            _current++;
        }
        public void Undo(int levels)
        {
            Console.WriteLine();
            Console.WriteLine("### UNDOING...");
            Console.WriteLine();

            for (var i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    var command = _commands[--_current];
                    command.Execute();
                }
            }
        }
        public void Redo(int levels)
        {
            Console.WriteLine();
            Console.WriteLine("### REDOING...");
            Console.WriteLine();

            for (var i = 0; i < levels; i++)
            {
                if (_current < _commands.Count)
                {
                    var command = _commands[_current++];
                    command.Execute();
                }
            }
        }
    }
}

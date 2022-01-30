using DesignPatterns.Creational.AbstractFactory;
using System;

namespace DesignPatterns.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryExecutor.Execute();

            Console.ReadKey();
        }
    }
}

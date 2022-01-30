using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using System;

namespace DesignPatterns.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryExecutor.Execute();
            FactoryMethodExecutor.Execute();

            Console.ReadKey();
        }
    }
}

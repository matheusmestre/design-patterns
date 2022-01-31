using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using System;

namespace DesignPatterns.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryExecutor.Execute();
            //FactoryMethodExecutor.Execute();
            SingletonExecutor.Execute();

            Console.ReadKey();
        }
    }
}

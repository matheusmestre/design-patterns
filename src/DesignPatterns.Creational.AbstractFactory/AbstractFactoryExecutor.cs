using DesignPatterns.Creational.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.AbstractFactory.Client;
using DesignPatterns.Creational.AbstractFactory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public static class AbstractFactoryExecutor
    {
        public static void Execute()
        {
            VehicleFactory factory = new HondaFactory();
            var client = new VehicleClient(factory, EProductType.BASIC);
            client.GetBikeName();
            client.GetCarName();

            Console.WriteLine();

            client = new VehicleClient(factory, EProductType.REGULAR);
            client.GetBikeName();
            client.GetCarName();

            Console.WriteLine();

            client = new VehicleClient(factory, EProductType.SPORTS);
            client.GetBikeName();
            client.GetCarName();

            Console.WriteLine();

            factory = new SuzukiFactory();
            client = new VehicleClient(factory, EProductType.BASIC);
            client.GetBikeName();
            client.GetCarName();

            Console.WriteLine();

            factory = new SuzukiFactory();
            client = new VehicleClient(factory, EProductType.REGULAR);
            client.GetBikeName();
            client.GetCarName();

            Console.WriteLine();

            factory = new SuzukiFactory();
            client = new VehicleClient(factory, EProductType.SPORTS);
            client.GetBikeName();
            client.GetCarName();
        }
    }
}

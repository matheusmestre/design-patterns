using DesignPatterns.Creational.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.Client
{
    public class VehicleClient
    {
        private readonly Bike _bike;
        private readonly Car _car;
        public VehicleClient(VehicleFactory factory, EProductType productType)
        {
            _bike = factory.CreateBike(productType);
            _car = factory.CreateCar(productType);
        }
        public void GetBikeName()
        {
            Console.WriteLine("Bike: " + _bike.GetName());
        }
        public void GetCarName()
        {
            Console.WriteLine("Car: " + _car.GetName());
        }
    }
}

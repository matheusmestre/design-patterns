using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.AbstractFactories
{
    public abstract class VehicleFactory
    {
        public abstract Car CreateCar(EProductType productType);
        public abstract Bike CreateBike(EProductType productType);
    }
}
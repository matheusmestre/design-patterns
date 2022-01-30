using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda
{
    public class HondaSportCar : Car
    {
        public override string GetName()
        {
            return "Honda Civic 2.0";
        }
    }
}

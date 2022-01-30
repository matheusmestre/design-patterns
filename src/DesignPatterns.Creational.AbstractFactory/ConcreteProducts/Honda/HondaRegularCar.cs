using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda
{
    public class HondaRegularCar : Car
    {
        public override string GetName()
        {
            return "Honda City 1.4";
        }
    }
}

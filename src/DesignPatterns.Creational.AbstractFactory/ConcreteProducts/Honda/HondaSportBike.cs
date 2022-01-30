using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda
{
    public class HondaSportBike : Bike
    {
        public override string GetName()
        {
            return "Honda CBR 1000RR-R Fireblade SP";
        }
    }
}

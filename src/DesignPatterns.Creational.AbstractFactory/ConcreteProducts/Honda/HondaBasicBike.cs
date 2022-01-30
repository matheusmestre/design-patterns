using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda
{
    public class HondaBasicBike : Bike
    {
        public override string GetName()
        {
            return "Honda CG 160 Start";
        }
    }
}

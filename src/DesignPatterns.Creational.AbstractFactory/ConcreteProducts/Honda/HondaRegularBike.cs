using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda
{
    public class HondaRegularBike : Bike
    {
        public override string GetName()
        {
            return "Honda CB 250F Twister";
        }
    }
}

using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Suzuki
{
    public class SuzukiRegularBike : Bike
    {
        public override string GetName()
        {
            return "Suzuki Inazuma 250";
        }
    }
}

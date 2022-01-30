using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Suzuki
{
    public class SuzukiSportBike : Bike
    {
        public override string GetName()
        {
            return "Suzuki GSX-R1000R";
        }
    }
}

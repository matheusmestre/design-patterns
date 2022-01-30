using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Suzuki
{
    public class SuzukiBasicCar : Car
    {
        public override string GetName()
        {
            return "Suzuki Jimny";
        }
    }
}

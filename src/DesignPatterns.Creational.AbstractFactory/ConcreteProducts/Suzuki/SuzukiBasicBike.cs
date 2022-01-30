using DesignPatterns.Creational.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Suzuki
{
    public class SuzukiBasicBike : Bike
    {
        public override string GetName()
        {
            return "Suzuki GSR 150";
        }
    }
}

using DesignPatterns.Creational.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Suzuki;
using System;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
    public class SuzukiFactory: VehicleFactory
    {
        public override Bike CreateBike(EProductType productType)
        {
            switch (productType)
            {
                case EProductType.BASIC:
                    return new SuzukiBasicBike();
                case EProductType.REGULAR:
                    return new SuzukiRegularBike();
                case EProductType.SPORTS:
                    return new SuzukiSportBike();
                default:
                    throw new NotImplementedException("Product Type not implemented for bikes");
            }
        }
        public override Car CreateCar(EProductType productType)
        {
            switch (productType)
            {
                case EProductType.BASIC:
                    return new SuzukiBasicCar();
                case EProductType.REGULAR:
                    return new SuzukiRegularCar();
                case EProductType.SPORTS:
                    return new SuzukiSportCar();
                default:
                    throw new NotImplementedException("Product Type not implemented for cars");
            }
        }
    }
}

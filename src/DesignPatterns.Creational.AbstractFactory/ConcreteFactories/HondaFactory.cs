using DesignPatterns.Creational.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts.Honda;
using System;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
    public class HondaFactory : VehicleFactory
    {
        public override Bike CreateBike(EProductType productType)
        {
            switch (productType)
            {
                case EProductType.BASIC:
                    return new HondaBasicBike();
                case EProductType.REGULAR:
                    return new HondaRegularBike();
                case EProductType.SPORTS:
                    return new HondaSportBike();
                default:
                    throw new NotImplementedException("Product Type not implemented for bikes");
            }
        }
        public override Car CreateCar(EProductType productType)
        {
            switch (productType)
            {
                case EProductType.BASIC:
                    return new HondaBasicCar();
                case EProductType.REGULAR:
                    return new HondaRegularCar();
                case EProductType.SPORTS:
                    return new HondaSportCar();
                default:
                    throw new NotImplementedException("Product Type not implemented for cars");
            }
        }
    }
}

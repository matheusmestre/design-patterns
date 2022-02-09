using DesignPatterns.Behavorial.Observer.ConcreteObserver;
using DesignPatterns.Behavorial.Observer.ConcreteSubject;
using DesignPatterns.Behavorial.Observer.Observer;
using DesignPatterns.Behavorial.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Observer
{
    public class ObserverExecutor
    {
        public static void Execute()
        {
            IInvestor john = new Investor("John");
            IInvestor mark = new Investor("Mark");
            IInvestor peter = new Investor("Peter");

            StockBase microsoft = new Stock("MSFT", 101.99m);
            microsoft.Subscribe(john);
            microsoft.Subscribe(mark);

            StockBase google = new Stock("GOOG", 156.71m);
            google.Subscribe(mark);

            StockBase apple = new Stock("AAPL", 204.36m);
            apple.Subscribe(john);
            apple.Subscribe(mark);
            apple.Subscribe(peter);

            microsoft.Price = 101.95m;
            google.Price = 156.70m;
            apple.Price = 204.31m;

            apple.Unsubscribe(john);
            apple.Unsubscribe(mark);

            microsoft.Price = 101.99m;
            google.Price = 156.73m;
            apple.Price = 204.35m;

            microsoft.Unsubscribe(john);

            microsoft.Price = 102.05m;
            google.Price = 156.97m;
            apple.Price = 204.59m;


        }
    }
}

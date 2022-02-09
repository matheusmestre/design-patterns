using DesignPatterns.Behavorial.Observer.Observer;
using DesignPatterns.Behavorial.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Observer.ConcreteObserver
{
    public class Investor : IInvestor
    {
        public Investor(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public void NotifyStockChange(StockBase stock)
        {
            Console.WriteLine($"Notifying {Name} that {stock.Symbol} has changed its price to {stock.Price}");
        }
    }
}

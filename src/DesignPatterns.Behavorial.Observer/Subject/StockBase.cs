using DesignPatterns.Behavorial.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavorial.Observer.Subject
{
    public abstract class StockBase
    {
        private List<IInvestor> _subscribedList = new List<IInvestor>();
        protected StockBase(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
        }
        public string Symbol { get; private set; }
        
        private decimal _price;
        public decimal Price {
            get 
            {
                return _price;
            }
            set 
            {
                if (value == _price) return;

                _price = value;
                Notify();
            } 
        }
        protected void Notify()
        {
            if (!_subscribedList.Any())
                return;

            Console.WriteLine();
            Console.WriteLine($"NOTIFYING {Symbol} CHANGE...");

            foreach (var subscribed in _subscribedList)
                subscribed.NotifyStockChange(this);
        }
        public void Subscribe(IInvestor investor)
        {
            _subscribedList.Add(investor);
            Console.WriteLine($"SUBSCRIBING {investor.Name} to {Symbol}");
        }
        public void Unsubscribe(IInvestor investor)
        {
            _subscribedList.Remove(investor);
            Console.WriteLine($"UNSUBSCRIBING {investor.Name} from {Symbol}");
        }
    }
}
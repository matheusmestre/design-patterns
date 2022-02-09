using DesignPatterns.Behavorial.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Observer.ConcreteSubject
{
    public class Stock : StockBase
    {
        public Stock(string symbol, decimal value) 
            : base(symbol, value)
        {
        }
    }
}

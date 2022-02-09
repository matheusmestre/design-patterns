using DesignPatterns.Behavorial.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Observer.Observer
{
    public interface IInvestor
    {
        string Name { get; }
        void NotifyStockChange(StockBase stock);
    }
}

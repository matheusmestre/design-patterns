using DesignPatterns.Behavorial.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavorial.Strategy.ConcreteStrategy
{
    public class DescendingSortStrategy : ISortStrategy
    {
        public List<string> Sort(List<string> list)
        {
            return list.OrderByDescending(x => x).ToList();
        }
    }
}

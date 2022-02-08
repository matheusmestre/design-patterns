using DesignPatterns.Behavorial.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavorial.Strategy.ConcreteStrategy
{
    public class RandomSortStrategy : ISortStrategy
    {
        private readonly Random _random = new Random();
        public List<string> Sort(List<string> list)
        {
            return list.OrderBy(x => _random.Next()).ToList();
        }
    }
}

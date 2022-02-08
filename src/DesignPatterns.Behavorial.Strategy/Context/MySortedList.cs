using DesignPatterns.Behavorial.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavorial.Strategy.Context
{
    public class MySortedList
    {
        private List<string> _list = new List<string>();
        private ISortStrategy _strategy;
        public MySortedList()
        {

        }
        public MySortedList(ISortStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Add(string item)
        {
            _list.Add(item);
        }
        public void Sort()
        {
            _list = _strategy.Sort(_list);

            foreach(var item in _list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("#####");
            Console.WriteLine();
        }
    }
}

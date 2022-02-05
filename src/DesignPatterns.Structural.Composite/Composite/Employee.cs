using DesignPatterns.Structural.Composite.Component;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite.Composite
{
    public class Employee : Employed, IEnumerable<Employed>
    {
        private readonly List<Employed> _subordinates;
        public Employee(string name) 
            : base(name)
        {
            _subordinates = new List<Employed>();
        }
        public override void AddSubordinate(Employed employed)
        {
            _subordinates.Add(employed);
        }
        public override void RemoveSubordinate(Employed employed)
        {
            _subordinates.Remove(employed);
        }
        public override void Display(int depth)
        {
            Console.WriteLine($"{ new string('-', depth) } {Id} - {Name}");

            foreach(var item in _subordinates)
                item.Display(depth + 3);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Employed> GetEnumerator()
        {
            return _subordinates.GetEnumerator();
        }
    }
}

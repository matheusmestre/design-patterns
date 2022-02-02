using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}

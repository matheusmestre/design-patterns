using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite.Component
{
    public abstract class Employed
    {        
        public Employed(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public abstract void AddSubordinate(Employed employed);
        public abstract void RemoveSubordinate(Employed employed);
        public abstract void Display(int depth);
    }
}

using DesignPatterns.Structural.Composite.Component;
using System;

namespace DesignPatterns.Structural.Composite.Leaf
{
    public class Assistant : Employed
    {
        public Assistant(string name) 
            : base(name)
        {
        }
        public override void AddSubordinate(Employed employed)
        {
            Console.WriteLine("Cannot add to an assistant!");
        }
        public override void RemoveSubordinate(Employed employed)
        {
            Console.WriteLine("Cannot remove from an assistant!");
        }
        public override void Display(int depth)
        {
            Console.WriteLine($"{ new string('-', depth) } {Id} - {Name}");
        }
    }
}

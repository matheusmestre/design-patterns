using DesignPatterns.Structural.Composite.Component;
using DesignPatterns.Structural.Composite.Composite;
using DesignPatterns.Structural.Composite.Leaf;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class CompositeExecutor
    {
        public static void Execute()
        {
            var emp1 = new Employee("Thiago");
            var emp2 = new Employee("Gabriel");
            var emp3 = new Employee("Jones");
            emp1.AddSubordinate(emp2);
            emp1.AddSubordinate(emp3);

            var emp4 = new Employee("Barbara");
            var emp5 = new Employee("André");
            var emp6 = new Employee("Cesar");
            emp2.AddSubordinate(emp4);
            emp3.AddSubordinate(emp5);
            emp3.AddSubordinate(emp6);

            var emp7 = new Employee("Igor");
            var emp8 = new Assistant("Gisnando");
            var emp9 = new Assistant("Gerlandio");
            var emp10 = new Assistant("Alexandre");
            emp2.AddSubordinate(emp7);
            emp5.AddSubordinate(emp8);
            emp5.AddSubordinate(emp9);
            emp6.AddSubordinate(emp10);

            emp1.Display(3);

            foreach (var emp in emp1)
            {
                //Do anything
            }
        }
    }
}

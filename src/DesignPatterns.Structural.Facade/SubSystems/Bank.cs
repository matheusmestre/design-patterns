using System;

namespace DesignPatterns.Structural.Facade.SubSystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.Write($"Check bank for {c.Name}...");
            Console.WriteLine("OK!");
            
            return true;
        }
    }
}

using System;
using System.Threading;

namespace DesignPatterns.Structural.Facade.SubSystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.Write($"Check credit for {c.Name}...");
            Console.WriteLine("OK!");
            return true;
        }
    }
}

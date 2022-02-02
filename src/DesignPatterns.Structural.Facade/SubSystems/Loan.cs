using System;
using System.Threading;

namespace DesignPatterns.Structural.Facade.SubSystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.Write($"Check loans for {c.Name}...");
            Console.WriteLine("OK!");
            return true;
        }
    }
}

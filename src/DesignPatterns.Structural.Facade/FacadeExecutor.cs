using DesignPatterns.Structural.Facade.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class FacadeExecutor
    {
        public static void Execute()
        {
            Mortgage mortgage = new Mortgage();
            
            Customer customer = new Customer("John Doe");
            bool eligible = mortgage.IsEligible(customer, 189000);
            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}

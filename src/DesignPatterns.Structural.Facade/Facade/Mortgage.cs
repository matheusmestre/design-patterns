using DesignPatterns.Structural.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.Facade
{
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);
            bool eligible = true;
            
            // Check creditworthyness of applicant
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}

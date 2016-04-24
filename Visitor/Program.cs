using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.BankAccounts.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.BankAccounts.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.RealEstates.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Loans.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            int netWorth = 0;

            foreach (var bankAccount in person.BankAccounts) // loop separately on each classes 
            {
                netWorth += bankAccount.Amount; // each have different attributes, can't group it in a particular class
            }

            foreach (var realEstate in person.RealEstates) // adding new operations for person (computing monthly income) will mean adding another set of loop
            {
                netWorth += realEstate.EstimatedValue;
            }

            foreach (var loan in person.Loans)
            {
                netWorth -= loan.Owed;
            }

            Console.WriteLine(netWorth);
            Console.ReadKey();
        }
    }
}

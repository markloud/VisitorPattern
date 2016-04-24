using System;
using VisitorImplemented.Asset;
using VisitorImplemented.Visitor;

namespace VisitorImplemented
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Structure
            var person = new Person(); 
            
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterestRate = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterestRate = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            // Visitor
            var netWorthVisitor = new NetWorthVisitor();
            person.Accept(netWorthVisitor);

            var monthlyincome = new MonthlyIncome();
            person.Accept(monthlyincome);

            Console.WriteLine("Net Worth: {0}",netWorthVisitor.Total);
            Console.WriteLine("Monthly Income: {0}", monthlyincome.Amount);
            Console.ReadKey();
        }
    }
}

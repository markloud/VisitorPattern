using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Person
    {
        public List<RealEstate> RealEstates = new List<RealEstate>();
        public List<BankAccount> BankAccounts = new List<BankAccount>();
        public List<Loan> Loans { get; set; } = new List<Loan>();
    }

    public class Loan
    {
        public int Owed { get; set; }
        public int MonthlyPayment { get; set; }
    }

    public class BankAccount
    {
        public int Amount { get; set; }
        public double MonthlyInterest { get; set; }
    }

    public class RealEstate
    {
        public int EstimatedValue { get; set; }
        public int MonthlyRent { get; set; }
    }
}

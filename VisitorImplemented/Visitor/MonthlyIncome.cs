using VisitorImplemented.Asset;

namespace VisitorImplemented.Visitor
{
    class MonthlyIncome : IVisitor
    {
        public double Amount;

        public void Visit(BankAccount bankAccount)
        {
            Amount += bankAccount.Amount * bankAccount.MonthlyInterestRate;
        }

        public void Visit(RealEstate realEstate)
        {
            Amount += realEstate.MonthlyRent; // house rental business
        }

        public void Visit(Loan loan)
        {
            Amount -= loan.MonthlyPayment;
        }

    }
}

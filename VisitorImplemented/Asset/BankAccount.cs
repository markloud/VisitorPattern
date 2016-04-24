using VisitorImplemented.Visitor;

namespace VisitorImplemented.Asset
{
    public class BankAccount : IAsset
    {
        public int Amount { get; set; }
        public double MonthlyInterestRate { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

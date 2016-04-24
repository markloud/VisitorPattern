using VisitorImplemented.Visitor;

namespace VisitorImplemented.Asset
{
    public class Loan : IAsset
    {
        public int Owed { get; set; }
        public int MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this); // pass asset instance
        }
    }
}

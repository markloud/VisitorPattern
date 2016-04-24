using VisitorImplemented.Asset;

namespace VisitorImplemented.Visitor
{
    public interface IVisitor
    {
        // method overload for each type (because each has different properties to handle)
        void Visit(RealEstate realEstate);

        void Visit(BankAccount bankAccount);

        void Visit(Loan loan);
    }
}
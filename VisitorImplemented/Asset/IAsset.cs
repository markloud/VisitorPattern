using VisitorImplemented.Visitor;

namespace VisitorImplemented.Asset
{
    public interface IAsset
    {
        void Accept(IVisitor visitor); // allow the visitor to operate on each Asset
    }
}

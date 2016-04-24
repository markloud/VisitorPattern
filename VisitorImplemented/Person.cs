using System.Collections.Generic;
using VisitorImplemented.Asset;
using VisitorImplemented.Visitor;

namespace VisitorImplemented
{
    /// <summary>
    /// Object Structure
    /// </summary>
    class Person : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets) // chain to make sure each asset is visited
            {
                asset.Accept(visitor);
            }
        }
    }
}

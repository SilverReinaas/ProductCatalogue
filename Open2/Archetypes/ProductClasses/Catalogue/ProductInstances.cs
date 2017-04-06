using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductInstances : BaseClasses.Archetypes<ProductInstace>
    {
        public static ProductInstances Instance { get; } = new ProductInstances();
        public static ProductInstances GetProductInstances(string productTypeId)
        {
            var e = new ProductInstances();
            var l = Instance.FindAll(x => x.ProductTypeId == productTypeId);
            e.AddRange(l);
            return e;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductTypes : BaseClasses.Archetypes<ProductType>
    {
        public static ProductTypes Instance { get; } = new ProductTypes();
        public static ProductTypes GetProductTypes(string catalogueId)
        {
            var e = new ProductTypes();
            var l = Instance.FindAll(x => x.IsThisUniqueId(catalogueId));
            e.AddRange(l);
            return e;
        }

        public static ProductTypes Random()
        {
            ProductTypes result = new ProductTypes();
            for (int i = 0; i < GetRandom.Int16(1, 5); i++)
            {
                result.Add(ProductType.Random());
            }
            return result;
        }
    }
}

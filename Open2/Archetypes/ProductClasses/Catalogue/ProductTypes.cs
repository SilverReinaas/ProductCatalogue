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
        public static ProductType Find(string uniqueId) { return Instance.Find(x => x.IsThisUniqueId(uniqueId)); }
        public static ProductTypes GetProductTypes(string catalogueEntryId)
        {
            var e = new ProductTypes();
            var l = Instance.FindAll(x => x.CatalogueEntryId == catalogueEntryId);
            e.AddRange(l);
            return e;
        }
    }
}

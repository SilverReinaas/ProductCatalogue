using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Archetypes.ProductClasses.Catalogue //TODO luua mitu mitmele seos kategooriate ja entryde vahel
{
    public class ProductCategories : BaseClasses.Archetypes<ProductCategory>
    {
        public static ProductCategories Instance { get; } = new ProductCategories();

        public static ProductCategories GetProductCategories(string catalogueEntryId)
        {
            var e = new ProductCategories();
            var l = Instance.FindAll(x => x.CatalogueEntryId == catalogueEntryId);
            e.AddRange(l);
            return e;
        }
    }
}

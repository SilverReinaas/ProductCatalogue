using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueCategories : BaseClasses.Archetypes<CatalogueCategory> 
    {
        public static CatalogueCategories Instance { get; } = new CatalogueCategories();

        public static CatalogueCategories GetCatalogueCategories(string catalogueId)
        {
            var e = new CatalogueCategories();
            var l = Instance.FindAll(x => x.IsThisUniqueId(catalogueId));
            e.AddRange(l);
            return e;
        }
    }
}

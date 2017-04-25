using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CataloguesByCategory : Archetypes<CatalogueByCategory>
    {
        public static CataloguesByCategory Instance { get; } = new CataloguesByCategory();
        public static CatalogueByCategory Find(string uniqueId)
        {
            return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        }

        public static CatalogueCategories GetCategoriesByCatalogue(string catalogueId)
        {
            var result = new CatalogueCategories();
            var categoryIds = Instance.FindAll(x => x.CatalogueId == catalogueId);
            result.AddRange(
                CatalogueCategories.Instance.FindAll(
                    x => categoryIds.Contains(y => y.CatalogueCategoryId == x.UniqueId)));
            return result;
        }
    }
}

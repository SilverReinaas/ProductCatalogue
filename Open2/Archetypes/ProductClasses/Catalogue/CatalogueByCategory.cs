using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueByCategory : BaseEntity<CatalogueByCategory>
    {
        public string CatalogueCategoryId { get; set; }
        public string CatalogueId { get; set; }
        public override CatalogueByCategory Type
            => CataloguesByCategory.Find(UniqueId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Logic.CatalogueClasses
{
    public class ProductTypeModel
    {
        public ProductTypeModel() { }
        public ProductTypeModel(ProductType a)
        {
            UniqueId = a.UniqueId;
            Name = a.Name;
            Description = a.Description;
            ValidFrom = a.Valid.From;
            ValidTo = a.Valid.To;
            CatalogueEntryId = a.CatalogueEntryId;

        }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string CatalogueEntryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Logic.CatalogueClasses
{
    public class EntryEditModel
    {
        public EntryEditModel() { }
        public EntryEditModel(CatalogueEntry a)
        {
            if (a == null) return;
            UniqueId = a.UniqueId;
            Name = a.Name;
            ValidFrom = a.Valid.From;
            ValidTo = a.Valid.To;
            ProductTypes = new List<ProductTypeModel>();

            foreach (var type in a.ProductTypes)
            {
                ProductTypes.Add(new ProductTypeModel(type));
            }
        }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public List<ProductTypeModel> ProductTypes { get; set; }

    }
}

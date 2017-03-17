using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductCatalogue : UniqueEntity
    {
        private List<CatalogueEntry> catalogueEntries;
        private List<CatalogueCategory> catalogueCategories;
        public string Name { get; set; }
        public List<CatalogueEntry> CatalogueEntries
        {
            get { return catalogueEntries ?? new List<CatalogueEntry>(); }
            set { catalogueEntries = value; }
        }

        public List<CatalogueCategory> CatalogueCategories
        {
            get { return catalogueCategories ?? new List<CatalogueCategory>(); }
            set { catalogueCategories = value; }
        }
    }
}

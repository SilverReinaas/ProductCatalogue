using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductCatalogue : UniqueEntity
    {
        private Archetypes<CatalogueEntry> catalogueEntries;
        private Archetypes<CatalogueCategory> catalogueCategories;
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public Archetypes<CatalogueEntry> CatalogueEntries
        {
            get { return catalogueEntries ?? new Archetypes<CatalogueEntry>(); }
            set { catalogueEntries = value; }
        }

        public Archetypes<CatalogueCategory> CatalogueCategories
        {
            get { return catalogueCategories ?? new Archetypes<CatalogueCategory> (); }
            set { catalogueCategories = value; }
        }
    }
}

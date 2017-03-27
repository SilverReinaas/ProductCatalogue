using Open.Aids;
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

        public static ProductCatalogue Random()
        {
            var result = new ProductCatalogue()
            {
                Name = GetRandom.String(10,15),
                UniqueId = GetRandom.String(10,15)
            };

            for (int i = 0; i < GetRandom.Int16(10,50); i++)
            {
                result.CatalogueEntries.Add(CatalogueEntry.Random());
            }

            for (int i = 0; i < GetRandom.Int16(1, 5); i++)
            {
                result.CatalogueCategories.Add(CatalogueCategory.Random());
            }
        }
    }
}

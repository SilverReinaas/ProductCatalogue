using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductCatalogue : UniqueEntity
    {
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public CatalogueEntries CatalogueEntries => CatalogueEntries.GetCatalogueEntries(UniqueId);

        public CatalogueCategories CatalogueCategories => CatalogueCategories.GetCatalogueCategories(UniqueId);
        
        public static ProductCatalogue Random()
        {
            var result = new ProductCatalogue()
            {
                Name = GetRandom.String(10,15),
                UniqueId =  "abc123",//GetRandom.String(10,15),
            };
            return result;
        }
    }
}

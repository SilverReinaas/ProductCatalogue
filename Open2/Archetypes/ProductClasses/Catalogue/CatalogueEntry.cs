using Open.Archetypes.BaseClasses;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntry : UniqueEntity
    {
        private string name;
        private string catalogueid;
        public string CatalogueId
        {
            get { return SetDefault(ref catalogueid); }
            set { SetValue(ref catalogueid, value); }
        }
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        
        public ProductTypes ProductTypes => ProductTypes.GetProductTypes(UniqueId);
        public ProductCategories ProductCategories => ProductCategories.GetProductCategories(UniqueId);
        
        public static CatalogueEntry Random()
        {
            var result = new CatalogueEntry
            {
                Name = GetRandom.String(),
                UniqueId = GetRandom.String(),
            }; 
            return result;
        }
    }
}

using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductCategory : UniqueEntity
    {
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public static ProductCategory Random()
        {
            return new ProductCategory()
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15)
            };
        }
    }
}

using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductType : UniqueEntity
    {
        private string name;
        private string description;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
    }
}

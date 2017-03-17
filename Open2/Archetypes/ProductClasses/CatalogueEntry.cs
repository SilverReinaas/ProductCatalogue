using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogueEntry : UniqueEntity
    {
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        private List<ProductType> productTypes;
        public List<ProductType> ProductTypes
        {
            get { return productTypes ?? new List<ProductType>(); }
            set { productTypes = value; }
        }
        private List<ProductCategory> productCategories;
        public List<ProductCategory> ProductCategories
        {
            get { return productCategories ?? new List<ProductCategory>(); }
            set { productCategories = value; }
        }
    }
}

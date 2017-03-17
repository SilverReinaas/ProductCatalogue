using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntry : UniqueEntity
    {
        public string Name { get; set; }
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

using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntry : UniqueEntity
    {
        private string name;
        private Archetypes<ProductType> productTypes;
        private Archetypes<ProductCategory> productCategories;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public Archetypes<ProductType> ProductTypes
        {
            get { return productTypes ?? new Archetypes<ProductType>(); }
            set { productTypes = value; }
        }
        public Archetypes<ProductCategory> ProductCategories
        {
            get { return productCategories ?? new Archetypes<ProductCategory>(); }
            set { productCategories = value; }
        }
    }
}

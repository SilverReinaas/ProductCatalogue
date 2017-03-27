using System.Collections.Generic;
using Open.Archetypes.BaseClasses;
using Open.Aids;

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
        public static CatalogueEntry Random()
        {
            var result = new CatalogueEntry()
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15),
            };
            for (int i = 0; i < GetRandom.Int8(10, 50); i++)
            {
                result.ProductTypes.Add(ProductType.Random());
            }
            for (int i = 0; i < GetRandom.Int8(10, 50); i++)
            {
                result.ProductCategories.Add(ProductCategory.Random());
            }
            return result;
        }
    }
}

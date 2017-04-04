using System.Collections.Generic;
using Open.Archetypes.BaseClasses;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntry : UniqueEntity
    {
        private string name;
        private string description;
        private Archetypes<ProductCategory> productCategories;
        public string CatalogueId
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
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
        public ProductTypes ProductTypes => Catalogue.ProductTypes.GetProductTypes(UniqueId);

        public Archetypes<ProductCategory> ProductCategories
        {
            get { return productCategories ?? new Archetypes<ProductCategory>(); }
            set { productCategories = value; }
        }
        public static CatalogueEntry Random()
        {
            var result = new CatalogueEntry
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15),
            };
            for (int i = 0; i < GetRandom.Int8(1, 5); i++)
            {
                result.ProductTypes.Add(ProductType.Random());
            }
            for (int i = 0; i < GetRandom.Int8(1, 5); i++)
            {
                result.ProductCategories.Add(ProductCategory.Random());
            }
            return result;
        }
    }
}

﻿using Open.Aids;
using Open.Archetypes.BaseClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductCategory : BaseType<ProductCategory>
    {
        private string name;
        private string catalogueEntryId;
        [Key, Column(Order = 3)]
        public string CatalogueEntryId
        {
            get { return SetDefault(ref catalogueEntryId); }
            set { SetValue(ref catalogueEntryId, value); }
        }
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
        public override ProductCategory Type => ProductCategories.Find(TypeId);

    }
}

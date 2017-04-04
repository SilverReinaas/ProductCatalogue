﻿using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductType : UniqueEntity
    {
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public static ProductType Random()
        {
            return new ProductType()
            {
                UniqueId = GetRandom.String(10, 15),
                Name = GetRandom.String(10, 15)
            };
        }
    }
}

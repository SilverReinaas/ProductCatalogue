﻿using Open.Archetypes.BaseClasses;
using Open.Aids;
using System.ComponentModel.DataAnnotations;
using Open.Archetypes.OrderClasses;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntry : BaseEntity<CatalogueEntry>
    {
        
        private string name;
        private string catalogueid;
        [Key, Column(Order = 0)]
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
        public override CatalogueEntry Type => CatalogueEntries.Find(TypeId);
    }
}

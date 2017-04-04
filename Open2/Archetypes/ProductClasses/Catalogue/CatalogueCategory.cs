using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueCategory : UniqueEntity
    {
        private string name;
        private string catalogueID;

        public string CatalogueId
        {
            get { return SetDefault(ref catalogueID); }
            set { SetValue(ref catalogueID, value); }
        }
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public static CatalogueCategory Random()
        {
            return new CatalogueCategory()
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15)
            };
        }
    }
}

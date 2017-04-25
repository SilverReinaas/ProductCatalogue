using Open.Aids;
using Open.Archetypes.BaseClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductType : BaseType<ProductType>
    {
        private string name;
        private string catalogueEntryId;
        private string description;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        [Key, Column(Order = 3)]
        public string CatalogueEntryId {
            get { return SetDefault(ref catalogueEntryId); }
            set { SetValue(ref catalogueEntryId, value); }
        }
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
        public ProductInstances ProductInstances => ProductInstances.GetProductInstances(UniqueId);
        public static ProductType Random()
        {
            return new ProductType()
            {
                UniqueId = GetRandom.String(10, 15),
                Name = GetRandom.String(10, 15)
            };
        }

        public override ProductType Type => ProductTypes.Find(TypeId);
    }
}

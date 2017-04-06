using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class ProductInstace : UniqueEntity
    {
        private string name;
        private string description;
        private string productTypeId;
        public string ProductTypeId
        {
            get { return SetDefault(ref productTypeId); }
            set { SetValue(ref productTypeId, value); }
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

        public static ProductInstace Random()
        {
            var result = new ProductInstace()
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15),
            };
            return result;
        }
    }
}

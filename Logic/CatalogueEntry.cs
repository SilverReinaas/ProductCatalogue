using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CatalogueEntry : INamed, ITimeLimited
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Period Valid { get; set; }
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

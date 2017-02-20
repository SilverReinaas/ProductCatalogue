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
        public List<ProductType> ProductTypes { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

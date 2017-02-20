using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductCatalogue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<CatalogueEntry> CatalogueEntries;
        public List<CatalogueCategory> CatalogueCategories;
    }
}

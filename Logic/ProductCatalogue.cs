using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductCatalogue : INamed , ITimeLimited
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Period Valid { get; set; }
        public List<CatalogueEntry> CatalogueEntries { get; set; }
        public List<CatalogueCategory> CatalogueCategories { get; set; }
    }
}

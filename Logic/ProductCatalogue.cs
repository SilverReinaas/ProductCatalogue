using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductCatalogue : INamed, ITimeLimited
    {
        private List<CatalogueEntry> catalogueEntries;
        private List<CatalogueCategory> catalogueCategories;
        public string Id { get; set; }
        public string Name { get; set; }
        public Period Valid { get; set; }
        public List<CatalogueEntry> CatalogueEntries
        {
            get { return catalogueEntries ?? new List<CatalogueEntry>(); }
            set { catalogueEntries = value; }
        }

        public List<CatalogueCategory> CatalogueCategories
        {
            get { return catalogueCategories ?? new List<CatalogueCategory>(); }
            set { catalogueCategories = value; }
        }
    }
}

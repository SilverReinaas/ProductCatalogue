using System.Collections.Generic;

namespace Soft.Models
{
    public class ProductCatalogueViewModel
    {
        public string CatalogueName { get; set; }
        public List<CatalogueEntryViewModel> CatalogueEntries { get; set; }
    }
}
using System.Collections.Generic;

namespace Open.Logic.CatalogueClasses
{
    public class ProductCatalogueViewModel
    {
        public string CatalogueName { get; set; }
        public List<EntryEditModel> CatalogueEntries { get; set; }
    }
}
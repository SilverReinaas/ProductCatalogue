using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soft.Models
{
    public class CatalogueEntryViewModel
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
    }
}
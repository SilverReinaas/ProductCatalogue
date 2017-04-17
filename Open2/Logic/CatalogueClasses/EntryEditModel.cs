using System;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Logic.CatalogueClasses
{
    public class EntryEditModel
    {
        public EntryEditModel() { }
        public EntryEditModel(CatalogueEntry a)
        {
            UniqueId = a.UniqueId;
            Name = a.Name;
            ValidFrom = a.Valid.From;
            ValidTo = a.Valid.To;
        }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}

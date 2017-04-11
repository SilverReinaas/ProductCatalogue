using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntries : BaseClasses.Archetypes<CatalogueEntry>
    {
        public static CatalogueEntries Instance { get; } = GenerateRandomInstance();
        public static CatalogueEntries GetCatalogueEntries(string catalogueId)
        {
            var e = new CatalogueEntries();
            var l = Instance.FindAll(x => x.CatalogueId == catalogueId);
            e.AddRange(l);
            return e;
        }
        public static CatalogueEntries GenerateRandomInstance()
        {
            var result = new CatalogueEntries();;
            for (int i = 0; i < GetRandom.Int16(10, 30); i++)
            {
                var rand = CatalogueEntry.Random();
                rand.CatalogueId = "abc123";
                result.Add(rand);
            }
            return result;
        }
    }
}

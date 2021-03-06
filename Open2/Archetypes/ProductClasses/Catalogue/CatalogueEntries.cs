﻿using System;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntries : BaseClasses.Archetypes<CatalogueEntry>
    {
        public static CatalogueEntries Instance { get; } = new CatalogueEntries();
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
            for (int i = 0; i < GetRandom.Int32(20, 30); i++)
            {
                var rand = CatalogueEntry.Random();
                rand.CatalogueId = "abc123";
                result.Add(rand);
            }
            return result;
        }
        public static CatalogueEntry Find(string uniqueId)
        {
            return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        }

        public static void Remove(string id)
        {
            Instance.Remove(Find(id));
        }
    }
}   

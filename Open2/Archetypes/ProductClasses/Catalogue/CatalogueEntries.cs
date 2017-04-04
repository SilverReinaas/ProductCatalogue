﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;

namespace Open.Archetypes.ProductClasses.Catalogue
{
    public class CatalogueEntries : BaseClasses.Archetypes<CatalogueEntry>
    {
        public static CatalogueEntries Instance { get; } =  new CatalogueEntries();
        public static CatalogueEntries GetCatalogueEntries(string catalogueId)
        {
            var e = new CatalogueEntries();
            var l = Instance.FindAll(x => x.CatalogueId == catalogueId);
            e.AddRange(l);
            return e;
        }
    }
}
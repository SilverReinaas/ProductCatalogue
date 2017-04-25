using Open.Archetypes.ProductClasses.Catalogue;
using Open.Data.CatalogueData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soft.Models.CatalogueLayers
{
    public class EntryBusinessLayer
    {
        CatalogueDAL catDal = new CatalogueDAL();
        public List<CatalogueEntry> GetEntries()
        {
            return catDal.CatalogueEntries.ToList();
        }
        public CatalogueEntry SaveEntry(CatalogueEntry c)
        {
            catDal.CatalogueEntries.Add(c);
            catDal.SaveChanges();
            return c;
        }
        public void UploadEntries(List<CatalogueEntry> entries)
        {
            catDal.CatalogueEntries.AddRange(entries);
            catDal.SaveChanges();
        }
    }
}
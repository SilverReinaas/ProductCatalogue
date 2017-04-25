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

        public List<CatalogueEntry> GetEntries()
        {
            CatalogueDAL catDal = new CatalogueDAL();
            return catDal.CatalogueEntries.ToList();
        }
        public CatalogueEntry SaveEntry(CatalogueEntry c)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            catDal.CatalogueEntries.Add(c);
            catDal.SaveChanges();
            return c;
        }
        public void UploadEntries(List<CatalogueEntry> entries)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            catDal.CatalogueEntries.AddRange(entries);
            catDal.SaveChanges();
        }
    }
}
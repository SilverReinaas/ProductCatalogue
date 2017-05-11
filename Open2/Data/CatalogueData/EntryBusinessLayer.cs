using Open.Archetypes.ProductClasses.Catalogue;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Open.Data.CatalogueData
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
            catDal.CatalogueEntries.AddOrUpdate(c);
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

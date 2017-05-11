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
            foreach (var entry in entries)
            {
                catDal.CatalogueEntries.AddOrUpdate(entry);
            }
            catDal.SaveChanges();
        }

        public void RemoveEntry(string id)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            var removeEntry = catDal.CatalogueEntries.FirstOrDefault(x => x.UniqueId == id);
            if (removeEntry == null) return;
            catDal.CatalogueEntries.Remove(removeEntry);
            catDal.SaveChanges();
            CatalogueEntries.Remove(id);
        }

        public List<ProductType> GetTypes()
        {
            CatalogueDAL catDal = new CatalogueDAL();
            return catDal.ProductTypes.ToList();
        }
        public ProductType SaveType(ProductType c)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            catDal.ProductTypes.AddOrUpdate(c);
            catDal.SaveChanges();
            return c;
        }
        public void UploadTypes(List<ProductType> types)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            foreach (var type in types)
            {
                catDal.ProductTypes.AddOrUpdate(type);
            }
            catDal.SaveChanges();
        }

        public void RemoveType(string id)
        {
            CatalogueDAL catDal = new CatalogueDAL();
            var removeType = catDal.ProductTypes.FirstOrDefault(x => x.UniqueId == id);
            if (removeType == null) return;
            catDal.ProductTypes.Remove(removeType);
            catDal.SaveChanges();
            ProductTypes.Remove(id);
        }
    }
}

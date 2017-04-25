using Open.Archetypes.ProductClasses.Catalogue;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Data.CatalogueData
{
    public class CatalogueDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogueEntry>().ToTable("TblEntry");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CatalogueEntry> CatalogueEntries { get; set; }
    }
}

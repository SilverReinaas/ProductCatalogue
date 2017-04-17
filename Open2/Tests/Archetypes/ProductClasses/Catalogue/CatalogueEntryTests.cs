using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses.Catalogue;
namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueEntryTests : CommonTests<CatalogueEntry>
    {
        public CatalogueEntry MyCatalogueEntry;
        [TestInitialize]
        public void InitializeTest()
        {
            MyCatalogueEntry = new CatalogueEntry();
        }
        [TestCleanup]
        public void CleanUpTest()
        {
            MyCatalogueEntry = null;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(MyCatalogueEntry);
        }

        [TestMethod]
        public void ProductTypesTest()
        {
            Assert.IsNotNull(MyCatalogueEntry.ProductTypes);
        }
        [TestMethod]
        public void ProductCategoriesTest()
        {
            Assert.IsNotNull(MyCatalogueEntry.ProductCategories);
        }
        [TestMethod]
        public void NameTest()
        {
            Obj = new CatalogueEntry();
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }       
        protected override CatalogueEntry GetRandomObj()
        {
            return CatalogueEntry.Random();
        }
        [TestMethod]
        public void CatalogueIdTest()
        {
            Obj = new CatalogueEntry();
            TestProperty(() => Obj.CatalogueId, x => Obj.CatalogueId = x);
        }
    }
}

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
        {/*
            Assert.IsNotNull(MyCatalogueEntry.Name);
            MyCatalogueEntry.Name = null;
            Assert.IsNotNull(MyCatalogueEntry.Name);
            MyCatalogueEntry.Name = "Marion";
            Assert.AreEqual("Marion", MyCatalogueEntry.Name);
            */
            Obj = new CatalogueEntry();
            TestProperty(()=> Obj.Name, x => Obj.Name = x );

        }
        [TestMethod]
        public void DescriptionTest()
        {
            Assert.IsNotNull(MyCatalogueEntry.Description);
            MyCatalogueEntry.Description = null;
            Assert.IsNotNull(MyCatalogueEntry.Description);
            MyCatalogueEntry.Description = "abc";
            Assert.AreEqual("abc", MyCatalogueEntry.Description);
        }
        protected override CatalogueEntry GetRandomObj()
        {
            return CatalogueEntry.Random();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses.Catalogue;
namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueEntryTests : CommonTests<CatalogueEntry>
    {
        
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Obj);
        }

        [TestMethod]
        public void ProductTypesTest()
        {
            Assert.IsNotNull(Obj.ProductTypes);
        }
        [TestMethod]
        public void ProductCategoriesTest()
        {
            Assert.IsNotNull(Obj.ProductCategories);
        }
        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }       
        protected override CatalogueEntry GetRandomObj()
        {
            return CatalogueEntry.Random();
        }
        [TestMethod]
        public void CatalogueIdTest()
        {
            TestProperty(() => Obj.CatalogueId, x => Obj.CatalogueId = x);
        }
    }
}

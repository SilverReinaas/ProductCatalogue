using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductCatalogueTests : CommonTests<ProductCatalogue>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Obj);
        }

        [TestMethod]
        public void CatalogueEntriesTest()
        {
            Assert.IsNotNull(Obj.CatalogueEntries);
        }

        [TestMethod]
        public void CatalogueCategoriesTest()
        {
            Assert.IsNotNull(Obj.CatalogueCategories);
        }

        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }

        protected override ProductCatalogue GetRandomObj()
        {
            return ProductCatalogue.Random();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductCatalogueTests : ClassTests<ProductCatalogue>
    {
        private ProductCatalogue m;
        [TestInitialize]
        public void InitializeTest()
        {
            m = new ProductCatalogue();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            m = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void CatalogueEntriesTest()
        {
            Assert.IsNotNull(m.CatalogueEntries);
        }

        [TestMethod]
        public void CatalogueCategoriesTest()
        {
            Assert.IsNotNull(m.CatalogueCategories);
        }
    }
}

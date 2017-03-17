using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductCatalogueTests : ClassTests<ProductCatalogue>
    {
        private ProductCatalogue MyProductCatalogue;
        [TestInitialize]
        public void InitializeTest()
        {
            MyProductCatalogue = new ProductCatalogue();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            MyProductCatalogue = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(MyProductCatalogue);
        }

        [TestMethod]
        public void CatalogueEntriesTest()
        {
            Assert.IsNotNull(MyProductCatalogue.CatalogueEntries);
        }

        [TestMethod]
        public void CatalogueCategoriesTest()
        {
            Assert.IsNotNull(MyProductCatalogue.CatalogueCategories);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.IsNotNull(MyProductCatalogue.Name);
            MyProductCatalogue.Name = null;
            Assert.IsNotNull(MyProductCatalogue.Name);
            MyProductCatalogue.Name = "Marion";
            Assert.AreEqual("Marion", MyProductCatalogue.Name);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductCatalogueTests : CommonTests<ProductCatalogue>
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
            TestProperty(() => MyProductCatalogue.Name, x => MyProductCatalogue.Name = x);
        }

        protected override ProductCatalogue GetRandomObj()
        {
            return ProductCatalogue.Random();
        }
    }
}

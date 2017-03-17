using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class CatalogueEntryTests : ClassTests<CatalogueEntry>
    {
        public CatalogueEntry k;
        [TestInitialize]
        public void InitializeTest()
        {
            k = new CatalogueEntry();
        }
        [TestCleanup]
        public void CleanUpTest()
        {
            k = null;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(k);
        }

        [TestMethod]
        public void ProductTypeTest()
        {
            Assert.IsNotNull(k.ProductTypes);
        }

        [TestMethod]
        public void ProductCategoryTest()
        {
            Assert.IsNotNull(k.ProductCategories);
        }
    }
}
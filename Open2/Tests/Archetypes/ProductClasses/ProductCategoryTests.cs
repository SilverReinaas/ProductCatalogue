using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductCategoryTests : ClassTests<ProductCatalogue>
    {
        private ProductCategory myProductCategory;

        [TestInitialize]
        public void Init()
        {
            myProductCategory = new ProductCategory();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            myProductCategory = null;
        }

        [TestMethod]
        public void PeriodConstructorTest()
        {
            Assert.IsNotNull(myProductCategory);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.IsNotNull(myProductCategory);
        }
    }
}

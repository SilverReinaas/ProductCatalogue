using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductTypeTests : ClassTests<ProductType>
    {
        public ProductType p;
        [TestInitialize]
        public void InitializeTest()
        {
            p = new ProductType();
        }
        [TestCleanup]
        public void CleanupTest()
        {
            p = null;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(p);
        }
    }
}

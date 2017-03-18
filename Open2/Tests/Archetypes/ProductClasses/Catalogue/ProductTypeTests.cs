using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
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
        [TestMethod]
        public void NameTest()
        {
            Assert.IsNotNull(p.Name);
            p.Name = null;
            Assert.IsNotNull(p.Name);
            p.Name = "abc";
            Assert.AreEqual("abc", p.Name);
        }
    }
}

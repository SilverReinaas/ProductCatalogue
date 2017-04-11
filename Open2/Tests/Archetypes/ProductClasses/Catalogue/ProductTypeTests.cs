using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductTypeTests : CommonTests<ProductType>
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
            TestProperty(() => p.Name, x => p.Name = x);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            TestProperty(() => p.Description, x => p.Description = x);
        }
        protected override ProductType GetRandomObj()
        {
            return ProductType.Random();
        }
    }
}

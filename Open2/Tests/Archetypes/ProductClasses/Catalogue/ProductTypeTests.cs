using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductTypeTests : CommonTests<ProductType>
    {
       
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Obj);
        }
        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }
        [TestMethod]
        public void CatalogueEntryIdTest()
        {
            TestProperty(() => Obj.CatalogueEntryId, x => Obj.CatalogueEntryId = x);
        }
        [TestMethod]
        public void ProductInstancesTest()
        {
            Assert.IsNotNull(Obj.ProductInstances);
        }
        protected override ProductType GetRandomObj()
        {
            return ProductType.Random();
        }
    }
}

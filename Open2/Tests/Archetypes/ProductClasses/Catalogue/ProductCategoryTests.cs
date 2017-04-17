using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductCategoryTests : CommonTests<ProductCategory>
    {
        
        [TestMethod]
        public void PeriodConstructorTest()
        {
            var p = new ProductCategory().GetType().BaseType;
            Assert.AreEqual(p, typeof(BaseType<ProductCategory>));
        }

        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }
        [TestMethod]
        public void CatalogueEntryIdTest()
        {
            TestProperty(() => Obj.CatalogueEntryId, x => Obj.CatalogueEntryId = x);
        }

        protected override ProductCategory GetRandomObj()
        {
            return ProductCategory.Random();
        }
    }
}

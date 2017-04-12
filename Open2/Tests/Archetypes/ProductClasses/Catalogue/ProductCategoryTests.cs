using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductCategoryTests : CommonTests<ProductCategory>
    {
        
        [TestMethod]
        public void PeriodConstructorTest()
        {
            Assert.IsNotNull(Obj);
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

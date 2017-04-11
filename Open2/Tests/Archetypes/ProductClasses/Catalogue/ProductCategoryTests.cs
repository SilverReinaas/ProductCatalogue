using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class ProductCategoryTests : CommonTests<ProductCategory>
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
            Obj = new ProductCategory();
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }
        [TestMethod]
        public void CatalogueEntryId()
        {
            Obj = new ProductCategory();
            TestProperty(() => Obj.CatalogueEntryId, x => Obj.CatalogueEntryId = x);
        }

        protected override ProductCategory GetRandomObj()
        {
            return ProductCategory.Random();
        }
    }
}

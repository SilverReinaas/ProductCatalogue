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
        {/*
            Assert.IsNotNull(myProductCategory.Name);
            myProductCategory.Name = null;
            Assert.IsNotNull(myProductCategory.Name);
            myProductCategory.Name = "abc";
            Assert.AreEqual("abc", myProductCategory.Name);*/
            Obj = new ProductCategory();
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }

        protected override ProductCategory GetRandomObj()
        {
            return ProductCategory.Random();
        }
    }
}

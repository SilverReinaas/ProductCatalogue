using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueCategoryTests : ClassTests<CatalogueCategory>
    {
        public CatalogueCategory MyCatalogueCategory;

        [TestInitialize]
        public void Init()
        {
            MyCatalogueCategory = new CatalogueCategory();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(MyCatalogueCategory);
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.IsNotNull(MyCatalogueCategory.Name);
            MyCatalogueCategory.Name = null;
            Assert.IsNotNull(MyCatalogueCategory.Name);
            MyCatalogueCategory.Name = "Marion";
            Assert.AreEqual("Marion", MyCatalogueCategory.Name);
        }
    }
}

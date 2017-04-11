using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueCategoryTests : CommonTests<CatalogueCategory>
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
            TestProperty(() => MyCatalogueCategory.Name, x => MyCatalogueCategory.Name = x);
        }

        [TestMethod]
        public void CatalogueIdTest()
        {
            TestProperty(() => MyCatalogueCategory.CatalogueId, x => MyCatalogueCategory.CatalogueId = x);
        }


        protected override CatalogueCategory GetRandomObj()
        {
            return new CatalogueCategory()
            {
                Name = GetRandom.String(10, 15),
                UniqueId = GetRandom.String(10, 15)
            };
        }
    }
}

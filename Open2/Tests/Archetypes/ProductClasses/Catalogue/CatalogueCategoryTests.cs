using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueCategoryTests : CommonTests<CatalogueCategory>
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
        public void CatalogueIdTest()
        {
            TestProperty(() => Obj.CatalogueId, x => Obj.CatalogueId = x);
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

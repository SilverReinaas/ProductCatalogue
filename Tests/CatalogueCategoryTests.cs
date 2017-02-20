using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CatalogueCategoryTests
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
    }
}

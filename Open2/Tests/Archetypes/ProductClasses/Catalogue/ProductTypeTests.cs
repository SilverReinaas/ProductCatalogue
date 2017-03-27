﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.IsNotNull(p.Name);
            p.Name = null;
            Assert.IsNotNull(p.Name);
            p.Name = "abc";
            Assert.AreEqual("abc", p.Name);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            Assert.IsNotNull(p.Description);
            p.Description = null;
            Assert.IsNotNull(p.Description);
            p.Description = "abc";
            Assert.AreEqual("abc", p.Description);
        }
        protected override ProductType GetRandomObj()
        {
            return ProductType.Random();
        }
    }
}

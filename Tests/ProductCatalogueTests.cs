using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ProductCatalogueTests
    {
        private ProductCatalogue m;
        [TestInitialize]
        public void InitializeTest()
        {
            m = new ProductCatalogue();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            m = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(m, null);
        }
    }
}

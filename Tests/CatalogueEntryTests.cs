using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CatalogueEntryTests
    {
        public CatalogueEntry k;
        [TestInitialize]
        public void InitializeTest()
        {
            var k = new CatalogueEntry();
        }
        [TestCleanup]
        public void CleanUpTest()
        {
            k = null;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreNotEqual(k, null);
        }
    }
}

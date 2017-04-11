using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses.Catalogue;

namespace Open.Tests.Archetypes.ProductClasses.Catalogue
{
    [TestClass]
    public class CatalogueEntriesTests: CommonTests<CatalogueEntries>
    {
        [TestMethod]
        public void InstanceTest()
        {

        }

        [TestMethod]
        public void GetCatalogueEntriesTest()
        {

        }

        [TestMethod]
        public void GetRandomInstanceTest()
        {

        }
        protected override CatalogueEntries GetRandomObj() { return CatalogueEntries.GenerateRandomInstance(); }
    }
}

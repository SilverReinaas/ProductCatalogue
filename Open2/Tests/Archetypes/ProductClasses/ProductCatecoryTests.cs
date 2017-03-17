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
    public class ProductCatecoryTests
    {
        public ProductCategory MyProductCategory;

        [TestInitialize]
        public void Init()
        {
            MyProductCategory = new ProductCategory();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(MyProductCategory);
        }
    }
}

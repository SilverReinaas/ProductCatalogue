using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PeriodTests
    {
        private Period myPeriod;

        [TestInitialize]
        public void Init()
        {
            myPeriod = new Period();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            myPeriod = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(myPeriod);
        }

        [TestMethod]
        public void DateTimeFromIsNotNullTest()
        {
            DateTime from = myPeriod.From;
            Assert.IsNotNull(from);
        }

        [TestMethod]
        public void DateTimeToIsNotNullTest()
        {
            DateTime to = myPeriod.To;
            Assert.IsNotNull(to);
        }
    }
}

using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PeriodTests
    {
        public Period myPeriod;

        [TestInitialize]
        public void Init()
        {
            myPeriod = new Period();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(myPeriod);
        }

        [TestMethod]
        public void DateTimeFromIsNotNullTest()
        {
            DateTime From = new Period().From;
            Assert.IsNotNull(From);
        }

        [TestMethod]
        public void DateTimeToIsNotNullTest()
        {
            DateTime To = new Period().To;
            Assert.IsNotNull(To);
        }
    }
}

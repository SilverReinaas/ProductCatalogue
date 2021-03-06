﻿using System;
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
        public void PeriodConstructorTest()
        {
            Assert.IsNotNull(myPeriod);
        }

        [TestMethod]
        public void FromTest()
        {
            Assert.AreEqual(typeof(DateTime), myPeriod.From.GetType());
        }

        [TestMethod]
        public void ToTest()
        {
            Assert.AreEqual(typeof(DateTime), myPeriod.To.GetType());
        }
    }
}

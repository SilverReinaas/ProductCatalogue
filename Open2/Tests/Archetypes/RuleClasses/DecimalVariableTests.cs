﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses
{
    [TestClass]
    public class DecimalVariableTests: CommonTests<DecimalVariable>
    {
        protected override DecimalVariable GetRandomObj() {
            return DecimalVariable.Random();
        }
        [TestMethod]
        public override void IsEqualTest()
        {
            var s = GetRandom.Decimal();
            Assert.IsFalse(Obj.IsEqual(s));
            Assert.IsTrue(Obj.IsEqual(Obj.Value));
        }
        [TestMethod]
        public void IsNotEqualTest()
        {
            var s = GetRandom.Decimal();
            Assert.IsTrue(Obj.IsNotEqual(s));
            Assert.IsFalse(Obj.IsNotEqual(Obj.Value));
        }
        [TestMethod]
        public void IsGreaterTest()
        {
            var s = Obj.Value - GetRandom.Decimal(0, 100);
            Assert.IsTrue(Obj.IsGreater(s));
            Assert.IsFalse(Obj.IsGreater(Obj.Value));
        }
        [TestMethod]
        public void IsNotGreaterTest()
        {
            var s = Obj.Value - GetRandom.Decimal(0, 100);
            Assert.IsFalse(Obj.IsNotGreater(s));
            Assert.IsTrue(Obj.IsNotGreater(Obj.Value));
        }
        [TestMethod]
        public void IsLessTest()
        {
            var s = Obj.Value + GetRandom.Decimal(0, 100);
            Assert.IsTrue(Obj.IsLess(s));
            Assert.IsFalse(Obj.IsLess(Obj.Value));
        }
        [TestMethod]
        public void IsNotLessTest()
        {
            var s = Obj.Value + GetRandom.Decimal(0, 100);
            Assert.IsFalse(Obj.IsNotLess(s));
            Assert.IsTrue(Obj.IsNotLess(Obj.Value));
        }
        [TestMethod]
        public void ConvertTest()
        {
            var s = GetRandom.Decimal();
            var s1 = Obj.Convert(s.ToString(UseCulture.Current));
            Assert.AreEqual(s.ToString(UseCulture.Invariant),
                s1.ToString(UseCulture.Invariant));
        }
        [TestMethod]
        public void ValueTest()
        {
            Obj = new DecimalVariable();
            TestProperty(() => Obj.Value, x => Obj.Value = x, 0);
        }
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsFalse(Obj.IsEmpty());
            Assert.IsFalse(new DoubleVariable().IsEmpty());
            Assert.IsFalse(DoubleVariable.Random().IsEmpty());
            Assert.IsTrue(DoubleVariable.Empty.IsEmpty());
        }
        [TestMethod]
        public void EmptyTest()
        {
            TestSingleton(() => DoubleVariable.Empty);
        }
    }
}

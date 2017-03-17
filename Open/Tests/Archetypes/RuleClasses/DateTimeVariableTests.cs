using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses
{
    [TestClass]
    public class DateTimeVariableTests: CommonTests<DateTimeVariable>
    {
        protected override DateTimeVariable GetRandomObj() {
            return DateTimeVariable.Random();
        }
        [TestMethod]
        public override void IsEqualTest()
        {
            var x = GetRandom.DateTime();
            Assert.IsFalse(Obj.IsEqual(x));
            Assert.IsTrue(Obj.IsEqual(Obj.Value));
        }
        [TestMethod]
        public void IsNotEqualTest()
        {
            var x = GetRandom.DateTime();
            Assert.IsTrue(Obj.IsNotEqual(x));
            Assert.IsFalse(Obj.IsNotEqual(Obj.Value));
        }
        [TestMethod]
        public void IsGreaterTest()
        {
            var x = GetRandom.DateTime(max: Obj.Value);
            Assert.IsTrue(Obj.IsGreater(x));
            Assert.IsFalse(Obj.IsGreater(Obj.Value));
        }
        [TestMethod]
        public void IsNotGreaterTest()
        {
            var x = GetRandom.DateTime(max: Obj.Value);
            Assert.IsFalse(Obj.IsNotGreater(x));
            Assert.IsTrue(Obj.IsNotGreater(Obj.Value));
        }
        [TestMethod]
        public void IsLessTest()
        {
            var x = GetRandom.DateTime(Obj.Value);
            Assert.IsTrue(Obj.IsLess(x));
            Assert.IsFalse(Obj.IsLess(Obj.Value));
        }
        [TestMethod]
        public void IsNotLessTest()
        {
            var x = GetRandom.DateTime(Obj.Value);
            Assert.IsFalse(Obj.IsNotLess(x));
            Assert.IsTrue(Obj.IsNotLess(Obj.Value));
        }
        [TestMethod]
        public void ConvertTest()
        {
            var x = GetRandom.DateTime();
            var s = x.ToString("s");
            Assert.AreEqual(x.ToString(UseCulture.Invariant), Obj.Convert(s).ToString(UseCulture.Invariant));
        }
        [TestMethod]
        public void ValueTest()
        {
            Obj = new DateTimeVariable();
            TestProperty(() => Obj.Value, x => Obj.Value = x, DateTime.MinValue);
        }
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsFalse(Obj.IsEmpty());
            Assert.IsFalse(new DateTimeVariable().IsEmpty());
            Assert.IsFalse(DateTimeVariable.Random().IsEmpty());
            Assert.IsTrue(DateTimeVariable.Empty.IsEmpty());
        }
        [TestMethod]
        public void EmptyTest()
        {
            TestSingleton(() => DateTimeVariable.Empty);
        }
    }
}

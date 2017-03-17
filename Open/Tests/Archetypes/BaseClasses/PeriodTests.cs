using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class PeriodTests : CommonTests<Period> {
        [TestMethod] public void ConstructorTest() {
            Assert.AreEqual(Obj.GetType().BaseType, typeof(Interval<DateTime>));
        }
        [TestMethod] public void EmptyTest() {
            Assert.AreEqual(Period.Empty, Period.Empty);
            Assert.AreNotEqual(new Period(), Period.Empty);
        }
        [TestMethod] public void FromTest() {
            Obj = new Period();
            TestProperty(() => Obj.From, x => Obj.From = x, DateTime.MinValue);
        }
        [TestMethod] public void IsEmptyTest() {
            Assert.IsTrue(Period.Empty.IsEmpty());
            Assert.IsFalse(new Period().IsEmpty());
            Assert.IsFalse(Period.Random().IsEmpty());
        }
        [TestMethod] public void IsValidTest() {
            Obj = GetRandomObj();
            var d = GetRandom.DateTime(Obj.From, Obj.To);
            Assert.IsTrue(Obj.IsValid(d));
            Assert.IsTrue(Obj.IsValid(Obj.From));
            Assert.IsTrue(Obj.IsValid(Obj.To));
            Assert.IsFalse(Obj.IsValid(Obj.From.AddTicks(-1)));
            Assert.IsFalse(Obj.IsValid(Obj.To.AddTicks(1)));
        }
        [TestMethod] public void IsValidStaticTest() {
            Assert.IsTrue(Period.IsValid(DateTime.MinValue, DateTime.MaxValue));
            Assert.IsTrue(Period.IsValid(DateTime.Now, DateTime.Now.AddTicks(10)));
            Assert.IsFalse(Period.IsValid(DateTime.Now.AddTicks(-2), DateTime.Now.AddTicks(-1)));
        }
        [TestMethod] public void MinValueTest() {
            Assert.AreEqual(DateTime.MinValue.ToUniversalTime(), Period.MinValue);
        }
        [TestMethod] public void MaxValueTest() {
            Assert.AreEqual(DateTime.MaxValue.ToUniversalTime(), Period.MaxValue);
        }
        [TestMethod] public void ToTest() {
            Obj = new Period();
            TestProperty(() => Obj.To, x => Obj.To = x, Period.MaxValue);
        }
        protected override Period GetRandomObj() { return Period.Random(); }
    }
}

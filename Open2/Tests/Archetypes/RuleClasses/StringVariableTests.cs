using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class StringVariableTests : CommonTests<StringVariable> {
        protected override StringVariable GetRandomObj() { return StringVariable.Random(); }
        [TestMethod] public void IsEmptyTest() {
            Assert.IsFalse(Obj.IsEmpty());
            Assert.IsFalse(new StringVariable().IsEmpty());
            Assert.IsFalse(StringVariable.Random().IsEmpty());
            Assert.IsTrue(StringVariable.Empty.IsEmpty());
        }
        [TestMethod] public void IsNotEqualTest() {
            var s = GetRandom.String();
            Assert.IsTrue(Obj.IsNotEqual(s));
            Assert.IsFalse(Obj.IsNotEqual(Obj.Value));
        }
        [TestMethod] public void IsGreaterTest() {
            Obj.Value = "B" + Obj.Value;
            var s = "A" + GetRandom.String();
            Assert.IsTrue(Obj.IsGreater(s));
            Assert.IsFalse(Obj.IsGreater(Obj.Value));
        }
        [TestMethod] public void IsNotGreaterTest() {
            Obj.Value = "B" + Obj.Value;
            var s = "A" + GetRandom.String();
            Assert.IsFalse(Obj.IsNotGreater(s));
            Assert.IsTrue(Obj.IsNotGreater(Obj.Value));
        }
        [TestMethod]
        public void IsLessTest()
        {
            Obj.Value = "A" + Obj.Value;
            var s = "B" + GetRandom.String();
            Assert.IsTrue(Obj.IsLess(s));
            Assert.IsFalse(Obj.IsLess(Obj.Value));
        }
        [TestMethod]
        public void IsNotLessTest()
        {
            Obj.Value = "A" + Obj.Value;
            var s = "B" + GetRandom.String();
            Assert.IsFalse(Obj.IsNotLess(s));
            Assert.IsTrue(Obj.IsNotLess(Obj.Value));
        }
        [TestMethod]
        public void EmptyTest() { TestSingleton(() => StringVariable.Empty); }
        [TestMethod]
        public void ValueTest()
        {
            Obj = new StringVariable();
            TestProperty(() => Obj.Value, x => Obj.Value = x);
        }
    }
}

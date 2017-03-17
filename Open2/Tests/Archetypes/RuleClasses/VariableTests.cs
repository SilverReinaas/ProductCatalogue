using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class VariableTests : ClassTests<Variable<string>> {
        private class TestClass : Variable<string> {
            public new static TestClass Random() {
                var o = new TestClass();
                o.SetRandomValues();
                o.Value = GetRandom.String();
                o.Name = GetRandom.String();
                return o;
            }
        }
        private Variable<string> obj;
        private static Variable<string> GetRandomObj() {
            return TestClass.Random();
        }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = GetRandomObj();
        }
        [TestMethod] public void ConstructorTest() {
            Assert.AreEqual(obj.GetType().BaseType.BaseType, typeof(Operand));
        }
        [TestMethod] public void IsOperandTest() { Assert.IsFalse(obj.IsOperand()); }
        [TestMethod] public void IsOperatorTest() { Assert.IsFalse(obj.IsOperator()); }
        [TestMethod] public void IsVariableTest() { Assert.IsTrue(obj.IsVariable()); }
        [TestMethod] public void IsEqualTest() {
            var s = GetRandom.String();
            Assert.IsFalse(obj.IsEqual(s));
            Assert.IsTrue(obj.IsEqual(obj.Value));
        }
        [TestMethod] public void IsNotEqualTest() {
            var s = GetRandom.String();
            Assert.IsTrue(obj.IsNotEqual(s));
            Assert.IsFalse(obj.IsNotEqual(obj.Value));
        }
        [TestMethod] public void IsGreaterTest() {
            const string s = "AAAA";
            obj.Value = "Z" + GetRandom.String();
            Assert.IsTrue(obj.IsGreater(s));
            Assert.IsFalse(obj.IsGreater(obj.Value));
        }
        [TestMethod] public void IsNotGreaterTest() {
            const string s = "AAAA";
            obj.Value = "Z" + obj.Value;
            Assert.IsFalse(obj.IsNotGreater(s));
            Assert.IsTrue(obj.IsNotGreater(obj.Value));
        }
        [TestMethod] public void IsLessTest() {
            const string s = "ZZZZ";
            Assert.IsTrue(obj.IsLess(s));
            Assert.IsFalse(obj.IsLess(obj.Value));
        }
        [TestMethod] public void IsNotLessTest() {
            const string s = "ZZZZ";
            Assert.IsFalse(obj.IsNotLess(s));
            Assert.IsTrue(obj.IsNotLess(obj.Value));
        }
        [TestMethod] public void ConvertTest() {
            var s = GetRandom.String();
            Assert.AreEqual(s, obj.Convert(s));
        }
        [TestMethod] public void ValueTest() {
            obj.Value = string.Empty;
            TestProperty(() => obj.Value, x => obj.Value = x);
        }
        [TestMethod] public void EqualTest() { Assert.AreEqual(0, Variable<string>.Equal); }
        [TestMethod]
        public void LessTest() { Assert.AreEqual(-1, Variable<string>.Less); }
        [TestMethod]
        public void GreaterTest() { Assert.AreEqual(1, Variable<string>.Greater); }
    }
}

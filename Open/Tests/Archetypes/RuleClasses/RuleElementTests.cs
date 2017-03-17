using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class RuleElementTests : ClassTests<RuleElement> {
        private class TestClass : RuleElement {}
        private RuleElement obj;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod] public void ConstructorTest() {
            Assert.AreEqual(obj.GetType().BaseType.BaseType, typeof(Archetype));
        }
        [TestMethod] public void IsOperandTest() { Assert.IsFalse(obj.IsOperand()); }
        [TestMethod] public void IsOperatorTest() { Assert.IsFalse(obj.IsOperator()); }
        [TestMethod] public void IsVariableTest() { Assert.IsFalse(obj.IsVariable()); }
        [TestMethod] public void NameTest() { TestProperty(() => obj.Name, x => obj.Name = x); }
        [TestMethod] public void RandomTest() {
            var x = RuleElement.Random();
            var y = RuleElement.Random();
            Assert.AreNotEqual(x.ToString(), y.ToString());
            Assert.AreNotEqual(string.Empty, y.ToString());
        }
    }
}

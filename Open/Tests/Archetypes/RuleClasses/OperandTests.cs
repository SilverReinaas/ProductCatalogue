using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class OperandTests : CommonTests<Operand> {
        protected override Operand GetRandomObj() { return Operand.Random(); }
        [TestMethod] public void EmptyTest() { TestSingleton(() => Operand.Empty); }
        [TestMethod] public void IsEmptyTest() {
            Assert.IsFalse(Obj.IsEmpty());
            Assert.IsFalse(new Operand().IsEmpty());
            Assert.IsFalse(Operand.Random().IsEmpty());
            Assert.IsTrue(Operand.Empty.IsEmpty());
        }
        [TestMethod] public void IsOperandTest() {
            Assert.IsTrue(Obj.IsOperand());
            Assert.IsTrue(new Operand().IsOperand());
            Assert.IsTrue(Operand.Random().IsOperand());
            Assert.IsTrue(Operand.Empty.IsOperand());
        }
        [TestMethod] public void ToStringVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.String();
            var a = Operand.ToVariable(name, value) as StringVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToIntegerVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.Int32();
            var a = Operand.ToVariable(name, value) as IntegerVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToBooleanVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.Bool();
            var a = Operand.ToVariable(name, value) as BooleanVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToDoubleVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.String();
            var a = Operand.ToVariable(name, value) as StringVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToDecimalVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.Decimal();
            var a = Operand.ToVariable(name, value) as DecimalVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToDateTimeVariableTest() {
            var name = GetRandom.String();
            var value = GetRandom.DateTime();
            var a = Operand.ToVariable(name, value) as DateTimeVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value, a.Value);
        }
        [TestMethod] public void ToVariableTest() {
            var name = GetRandom.String();
            var value = Period.Random();
            var a = Operand.ToVariable(name, value) as StringVariable;
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(value.ToString(), a.Value);
        }
        [TestMethod] public void GetRandomInheritedTest() {
            var a = Operand.GetRandomInherited();
            var b = Operand.GetRandomInherited();
            Assert.AreNotEqual(a.ToString(), b.ToString());
            Assert.AreNotEqual(string.Empty, a.ToString());
        }
    }
}

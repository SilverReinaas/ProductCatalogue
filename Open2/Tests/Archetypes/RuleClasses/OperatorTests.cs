using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses
{
    [TestClass]
    public class OperatorTests: CommonTests<Operator>
    {
        protected override Operator GetRandomObj() {
            return Operator.Random();
        }
        [TestMethod] public void IsEmptyTest() {
            Assert.IsFalse(new Operator().IsEmpty());
            Assert.IsFalse(Operator.Random().IsEmpty());
            Assert.IsTrue(Operator.Empty.IsEmpty());
        }
        [TestMethod]
        public void IsOperatorTest()
        {
            Assert.IsTrue(new Operator().IsOperator());
            Assert.IsTrue(Operator.Random().IsOperator());
            Assert.IsTrue(Operator.Empty.IsOperator());
        }
        [TestMethod] public void OperationTest() {
            TestProperty(()=>Obj.Operation, x =>Obj.Operation= x);
        }
        [TestMethod] public void EmptyTest() {
            TestSingleton(()=>Operator.Empty);
        }
        [TestMethod] public void NameTest() {
            var n = Obj.Name;
            Assert.AreEqual(Obj.Operation.ToString(), n);
            Obj.Name = GetRandom.String();
            Assert.AreEqual(n, Obj.Name);
        }
    }
}

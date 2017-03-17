using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.MoneyClasses;
namespace Open.Tests.Archetypes.MoneyClasses {
    [TestClass] public class MoneyTests : ClassTests<Money> {
        [TestMethod] public void ConstructorTest() {
            var a = new Money().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.QuantityClasses;
namespace Open.Tests.Archetypes.QuantityClasses {
    [TestClass] public class QuantityTests : ClassTests<Quantity> {
        [TestMethod] public void ConstructorTest() {
            var a = new Quantity().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
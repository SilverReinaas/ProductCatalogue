using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.OrderClasses;
namespace Open.Tests.Archetypes.OrderClasses {
    [TestClass] public class OrderTests : ClassTests<Order> {
        [TestMethod] public void ConstructorTest() {
            var a = new Order().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
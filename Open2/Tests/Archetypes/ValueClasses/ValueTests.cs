using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ValueClasses;
namespace Open.Tests.Archetypes.ValueClasses {
    [TestClass] public class ValueTests : ClassTests<Value> {
        [TestMethod] public void ConstructorTest() {
            var a = new Value().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
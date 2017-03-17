using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class BaseEntityTests : ClassTests<BaseEntity<EntityType>> {
        private class TestClass : Entity {}
        [TestMethod] public void TypeIdTest() {
            var o = new TestClass();
            TestProperty(() => o.TypeId, x => o.TypeId = x);
        }
        [TestMethod] public void TypeTest() {
        }
    }
}

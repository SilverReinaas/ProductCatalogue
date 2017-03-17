using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class UniqueEntityTests : ClassTests<UniqueEntity> {
        private class TestClass : UniqueEntity {
            public static UniqueEntity Random() {
                var o = new TestClass();
                o.SetRandomValues();
                return o;
            }
        }
        private UniqueEntity obj;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = TestClass.Random();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) Attributes.Instance.Add(Attribute.Random());
        }
        [TestMethod] public void ConstructorTest() {
            var a = new TestClass().GetType().BaseType.BaseType;
            Assert.AreEqual(a, typeof(AttributedEntity));
        }
        [TestMethod] public void GetAttributesTest() {
            Assert.AreEqual(0, obj.GetAttributes().Count);
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) {
                var a = Attribute.Random();
                a.EntityId = obj.UniqueId;
                Attributes.Instance.Add(a);
            }
            Assert.AreEqual(c, obj.GetAttributes().Count);
        }
        [TestMethod] public void IsThisUniqueIdTest() {
            Assert.IsFalse(obj.IsThisUniqueId(null));
            Assert.IsFalse(obj.IsThisUniqueId(string.Empty));
            Assert.IsFalse(obj.IsThisUniqueId("   "));
            Assert.IsFalse(obj.IsThisUniqueId(GetRandom.String()));
            Assert.IsTrue(obj.IsThisUniqueId(obj.UniqueId));
        }
        [TestMethod] public void UniqueIdTest() {
            obj = new TestClass();
            TestProperty(()=>obj.UniqueId, x=>obj.UniqueId=x);
        }
    }
}

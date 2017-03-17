using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class SerializableTests : ClassTests<Serializable> {
        private Serializable obj;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new Period();
        }
        [TestMethod] public void ConstructorTest() {
            var a = new Serializable().GetType().BaseType;
            Assert.AreEqual(typeof(Root), a);
        }
        [TestMethod] public void FromJsonTest() { }
        [TestMethod] public void FromXmlTest() { }
        [TestMethod] public void ToJsonTest() {
            var e = ToJson(obj);
            var o = FromJson<Period>(e);
            var a = ToJson(o);
            Assert.AreEqual(e, a);
        }
        [TestMethod] public void ToXmlTest() {
            var e = ToXml(obj);
            var o = FromXml<Period>(e);
            var a = ToXml(o);
            Assert.AreEqual(e, a);
        }
    }
}

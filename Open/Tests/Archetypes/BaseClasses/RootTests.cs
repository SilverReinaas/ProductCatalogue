using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class RootTests : ClassTests<Root> {
        private Root obj;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new Root();
        }
        [TestMethod] public void ConstructorTest() {
            var a = obj.GetType().BaseType;
            Assert.AreEqual(typeof(object), a);
        }
        [TestMethod] public void IsEmptyTest() { Assert.IsFalse(obj.IsEmpty()); }
        [TestMethod] public void IsEqualTest() {
            var a = obj;
            var b = new Root();
            Assert.IsFalse(a.IsEqual(b));
            Assert.IsTrue(a.IsEqual(obj));
        }
        [TestMethod] public void StaticIsEqualTest() {
            var a = obj;
            var b = new Root();
            Assert.IsFalse(IsEqual(null, null));
            Assert.IsFalse(IsEqual(a, null));
            Assert.IsFalse(IsEqual(null, a));
            Assert.IsFalse(IsEqual(a, b));
            Assert.IsTrue(IsEqual(a, obj));
        }
        [TestMethod] public void IsNullTest() {
            Assert.IsTrue(IsNull(null));
            Assert.IsFalse(IsNull(new object()));
        }
        [TestMethod] public void IsStringEmptyTest() {
            Assert.IsTrue(IsEmpty(null));
            Assert.IsTrue(IsEmpty(string.Empty));
            Assert.IsFalse(IsEmpty(GetRandom.String()));
        }
        [TestMethod] public void IsSpacesTest() {
            Assert.IsTrue(IsSpaces(null));
            Assert.IsTrue(IsSpaces(string.Empty));
            Assert.IsTrue(IsSpaces("     "));
            Assert.IsFalse(IsSpaces(GetRandom.String()));
        }
    }
}

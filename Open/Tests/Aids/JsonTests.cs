using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Aids {
    [TestClass] public class JsonTests : ClassTests<Json> {
        [TestMethod] public void ToTest() {}
        [TestMethod] public void FromTest() {
            var o = Period.Random();
            var e = Json.To(o);
            var a = Json.To(Json.From<Period>(e));
            Assert.AreEqual(e, a);
        }
    }
}

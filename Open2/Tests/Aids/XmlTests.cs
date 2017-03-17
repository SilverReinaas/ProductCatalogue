using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Aids {
    [TestClass] public class XmlTests : ClassTests<Xml> {
        [TestMethod] public void ToTest() {
            FromTest();
        }
        [TestMethod] public void FromTest() {
            var o = Period.Random();
            var e = Xml.To(o);
            var a = Xml.To(Xml.From<Period>(e));
            Assert.AreEqual(e, a);
        }
    }
}

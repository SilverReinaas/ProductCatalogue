using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class CommonTests : ClassTests<Common> {
        [TestMethod] public void ConstructorTest() {
            var a = new Common().GetType().BaseType;
            Assert.AreEqual(typeof(Serializable), a);
        }
        [TestMethod] public void IsSameContentTest() {
            var x = Period.Random();
            var y = Period.Random();
            var z = Archetype.Clone(x);
            Assert.IsFalse(x.IsSameContent(y));
            Assert.IsTrue(x.IsSameContent(z));
        }
        [TestMethod] public void IsSameContentStaticTest() {
            var x = Period.Random();
            var y = Period.Random();
            var z = Archetype.Clone(x);
            Assert.IsFalse(Common.IsSameContent(x, y));
            Assert.IsTrue(Common.IsSameContent(x, z));
        }
        [TestMethod] public void ToStringTest() {
            var x = Period.Random();
            Assert.AreEqual(ToJson(x), x.ToString());
        }
        [TestMethod] public void ParseTest() {
            var x = Period.Random();
            var s = x.ToString();
            var y = Common.Parse<Period>(s);
            Assert.AreEqual(s, y.ToString());
        }
        [TestMethod] public void TryParseTest() {
            Action<string, bool, string> t = (x, y, z) => {
                Period p;
                var b = Common.TryParse(x, out p);
                Assert.AreEqual(y, b);
                Assert.AreEqual(z, p.ToString());
            };  
            var r = Period.Random();
            t(GetRandom.String(), false, new Period().ToString());
            t(r.ToString(), true, r.ToString());
        }
    }
}

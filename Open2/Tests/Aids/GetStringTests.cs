using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class GetStringTests : ClassTests<GetString> {
        private string x;
        private string y;
        private char c;
        private string s;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            x = GetRandom.String();
            y = GetRandom.String();
            c = Char.Tab;
            s = $"{x}{c}{y}";
        }
        [TestMethod] public void HeadTest() {
            Assert.AreEqual("a", GetString.Head("a.b.c", '.'));
            Assert.AreEqual(x, GetString.Head(s, c));
        }
        [TestMethod] public void TailTest() {
            Assert.AreEqual("b.c", GetString.Tail("a.b.c", '.'));
            Assert.AreEqual(y, GetString.Tail(s, c));
        }
    }
}
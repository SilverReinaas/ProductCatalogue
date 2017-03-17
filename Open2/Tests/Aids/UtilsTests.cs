using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class UtilsTests : ClassTests<Utils> {
        [TestMethod] public void IsNullTest() {
            Assert.IsTrue(Utils.IsNull(null));
            Assert.IsFalse(Utils.IsNull(GetRandom.String()));
            Assert.IsFalse(Utils.IsNull(GetRandom.Char()));
            Assert.IsFalse(Utils.IsNull(GetRandom.Decimal()));
            Assert.IsFalse(Utils.IsNull(new object()));
        }
    }
}

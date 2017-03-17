using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class GetEnumTests : ClassTests<GetEnum> {
        [TestMethod] public void CountTest() {
            var e = System.Enum.GetValues(typeof(IsoGender)).Length;
            var a = GetEnum.Count<IsoGender>();
            Assert.AreEqual(e, a);
        }
        [TestMethod] public void ValueTest() {
            Assert.AreEqual(IsoGender.NotKnown, GetEnum.Value<IsoGender>(0));
            Assert.AreEqual(IsoGender.Male, GetEnum.Value<IsoGender>(1));
            Assert.AreEqual(IsoGender.Female, GetEnum.Value<IsoGender>(2));
            Assert.AreEqual(IsoGender.NotApplicable, GetEnum.Value<IsoGender>(3));
            Assert.AreEqual(IsoGender.NotKnown, GetEnum.Value<IsoGender>(9));
        }
    }
}

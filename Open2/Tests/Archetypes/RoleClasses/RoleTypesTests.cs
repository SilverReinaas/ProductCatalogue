using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses
{
    [TestClass]
    public class RoleTypesTests: CommonTests<RoleTypes>
    {
        protected override RoleTypes GetRandomObj() {
            return RoleTypes.Random();
        }
        [TestMethod] public void FindTest() {
            var s = GetRandom.String();
            Assert.IsNull(RoleTypes.Find(s));
            var t = RoleType.Random();
            t.UniqueId = s;
            RoleTypes.Instance.Add(t);
            RoleTypes.Instance.AddRange(RoleTypes.Random());
            Assert.AreEqual(t, RoleTypes.Find(s));
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=>RoleTypes.Instance);
        }
    }
}

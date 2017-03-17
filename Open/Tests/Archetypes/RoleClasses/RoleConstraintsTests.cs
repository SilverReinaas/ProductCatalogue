using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses {
    [TestClass] public class RoleConstraintsTests : CommonTests<RoleConstraints> {
        protected override RoleConstraints GetRandomObj() { return RoleConstraints.Random(); }
        [TestMethod] public void GetTypeConstraintsTest() {
            var s = GetRandom.String();
            Assert.AreEqual(0, RoleConstraints.GetTypeConstraints(s).Count);
            var l = RoleConstraints.Random();
            foreach (var e in l) e.RoleTypeId = s;
            RoleConstraints.Instance.AddRange(l);
            RoleConstraints.Instance.AddRange(RoleConstraints.Random());
            Assert.AreEqual(l.Count, RoleConstraints.GetTypeConstraints(s).Count);
        }
        [TestMethod] public void FindTest() {
            var s = GetRandom.String();
            Assert.IsNull(RoleConstraints.Find(s));
            var l = RoleConstraint.Random();
            l.UniqueId = s;
            RoleConstraints.Instance.Add(l);
            RoleConstraints.Instance.AddRange(RoleConstraints.Random());
            Assert.AreEqual(l, RoleConstraints.Find(s));
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=>RoleConstraints.Instance);
        }
    }
}

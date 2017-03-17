using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses {
    [TestClass] public class RolesTests : CommonTests<Roles> {
        protected override Roles GetRandomObj() { return Roles.Random(); }
        [TestMethod] public void GetPerformerRolesTest() {
            var s = GetRandom.String();
            Assert.AreEqual(0, Roles.GetPerformerRoles(s).Count);
            var l = Roles.Random();
            foreach (var e in l) e.PerformerId = s;
            Roles.Instance.AddRange(l);
            Roles.Instance.AddRange(Roles.Random());
            Assert.AreEqual(l.Count, Roles.GetPerformerRoles(s).Count);
        }
        [TestMethod] public void FindTest() {
            var s = GetRandom.String();
            Assert.IsNull(Roles.Find(s));
            var l = Role.Random();
            l.UniqueId = s;
            Roles.Instance.Add(l);
            Roles.Instance.AddRange(Roles.Random());
            Assert.AreEqual(l, Roles.Find(s));
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=> Roles.Instance);
        }
    }
}

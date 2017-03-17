using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses {
    [TestClass] public class RoleTypeTests : CommonTests<RoleType> {
        protected override RoleType GetRandomObj() { return RoleType.Random(); }
        [TestMethod] public void ConstraintsTest() {
            Assert.AreEqual(0, Obj.Constraints.Count);
            var l = RoleConstraints.Random();
            foreach (var e in l) e.RoleTypeId = Obj.UniqueId;
            RoleConstraints.Instance.AddRange(l);
            RoleConstraints.Instance.AddRange(RoleConstraints.Random());
            Assert.AreEqual(l.Count, Obj.Constraints.Count);
        }
        [TestMethod] public void TypeTest() {
            Assert.IsNull(Obj.Type);
            var t = RoleType.Random();
            t.UniqueId = Obj.TypeId;
            RoleTypes.Instance.AddRange(RoleTypes.Random());
            RoleTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        }
    }
}

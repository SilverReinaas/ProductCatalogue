using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses {
    [TestClass] public class RoleConstraintTests : CommonTests<RoleConstraint> {
        protected override RoleConstraint GetRandomObj() { return RoleConstraint.Random(); }
        [TestMethod] public void ValidPerformerTypeIdTest() {
            Obj = new RoleConstraint();
            TestProperty(() => Obj.ValidPerformerTypeId, x => Obj.ValidPerformerTypeId = x);
        }
        [TestMethod] public void RoleTypeIdTest() {
            Obj = new RoleConstraint();
            TestProperty(() => Obj.RoleTypeId, x => Obj.RoleTypeId = x);
        }
        [TestMethod] public void ValidPerformerTypeTest() {
            Assert.IsNull(Obj.ValidPerformerType);
            EntityTypes.Instance.AddRange(EntityTypes.Random());
            var t = EntityType.Random();
            t.UniqueId = Obj.ValidPerformerTypeId;
            EntityTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.ValidPerformerType);
        }
        [TestMethod] public void RoleTypeTest() {
            Assert.IsNull(Obj.RoleType);
            RoleTypes.Instance.AddRange(RoleTypes.Random());
            var t = RoleType.Random();
            t.UniqueId = Obj.RoleTypeId;
            RoleTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.RoleType);
        }
    }
}

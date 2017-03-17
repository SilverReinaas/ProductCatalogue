using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class EntityTests : CommonTests<Entity> {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();

            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) { Roles.Instance.Add(Role.Random()); }
        }
        [TestCleanup] public override void TestCleanup() {
            base.TestCleanup();
            Roles.Instance.Clear();
        }
        protected override Entity GetRandomObj() { return Entity.Random(); }
        [TestMethod] public void TypeTest() {
            Assert.IsNull(Obj.Type);
            var e = new EntityType {UniqueId = Obj.TypeId};
            EntityTypes.Instance.Add(e);
            Assert.AreEqual(e, Obj.Type);
        }
        [TestMethod] public void RolesTest() {
            Assert.AreEqual(0, Obj.Roles.Count);
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) {
                var r = Role.Random();
                r.PerformerId = Obj.UniqueId;
                Roles.Instance.Add(r);
            }
            Assert.AreEqual(c, Obj.Roles.Count);
        }
        [TestMethod] public void TypeIdTest() {
            Obj = new Entity();
            TestProperty(() => Obj.TypeId, x => Obj.TypeId = x);
        }
    }
}

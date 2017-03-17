using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RoleClasses {
    [TestClass] public class RoleTests : CommonTests<Role> {
        protected override Role GetRandomObj() { return Role.Random(); }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) Entities.Instance.Add(Entity.Random());
        }
        [TestCleanup] public override void TestCleanup() {
            base.TestCleanup();
            Entities.Instance.Clear();
        }
        [TestMethod] public void ConstructorTest() {
            var a = new Role().GetType().BaseType;
            Assert.AreEqual(a, typeof(BaseEntity<RoleType>));
        }
        [TestMethod] public void PerformerTest() {
            Assert.IsNull(Obj.Performer);
            var e = Entity.Random();
            e.UniqueId = Obj.PerformerId;
            Entities.Instance.Add(e);
            Assert.AreEqual(e, Obj.Performer);
        }
        [TestMethod] public void IsPerformerIdTest() {
            Assert.AreEqual(false, Obj.IsPerformerId(GetRandom.String()));
            Assert.AreEqual(true, Obj.IsPerformerId(Obj.PerformerId));
        }
        [TestMethod] public void PerformerIdTest() {
            Obj = new Role();
            TestProperty(() => Obj.PerformerId, x => Obj.PerformerId = x);
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
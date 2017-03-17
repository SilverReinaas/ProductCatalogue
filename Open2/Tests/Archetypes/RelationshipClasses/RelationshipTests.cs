using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RelationshipClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RelationshipClasses {
    [TestClass] public class RelationshipTests : CommonTests<Relationship> {
        protected override Relationship GetRandomObj() { return Relationship.Random(); }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                Roles.Instance.Add(Role.Random());
        }
        [TestCleanup] public override void TestCleanup() {
            base.TestCleanup();
            Roles.Instance.Clear();
        }
        [TestMethod] public void ConstructorTest() {
            var a = new Relationship().GetType().BaseType;
            Assert.AreEqual(a, typeof(BaseEntity<RelationshipType>));
        }
        [TestMethod] public void ProviderTest() {
            Assert.IsNull(Obj.Provider);
            var r = Role.Random();
            r.UniqueId = Obj.ProviderId;
            Roles.Instance.Add(r);
            Assert.AreEqual(r, Obj.Provider);
        }
        [TestMethod] public void ConsumerTest() {
            Assert.IsNull(Obj.Consumer);
            var r = Role.Random();
            r.UniqueId = Obj.ConsumerId;
            Roles.Instance.Add(r);
            Assert.AreEqual(r, Obj.Consumer);
        }
        [TestMethod] public void IsInRoleTest() {
            Assert.IsFalse(Obj.IsInRole(null));
            Assert.IsFalse(Obj.IsInRole(string.Empty));
            Assert.IsFalse(Obj.IsInRole("   "));
            Assert.IsFalse(Obj.IsInRole(GetRandom.String()));
            Assert.IsTrue(Obj.IsInRole(Obj.ConsumerId));
            Assert.IsTrue(Obj.IsInRole(Obj.ProviderId));
        }
        [TestMethod] public void ProviderIdTest() {
            Obj = new Relationship();
            TestProperty(() => Obj.ProviderId, x => Obj.ProviderId = x);
        }
        [TestMethod] public void ConsumerIdTest() {
            Obj = new Relationship();
            TestProperty(() => Obj.ConsumerId, x => Obj.ConsumerId = x);
        }
        [TestMethod] public void TypeTest() {
            Assert.IsNull(Obj.Type);
            var t = RelationshipType.Random();
            Obj.TypeId = t.UniqueId;
            RelationshipTypes.Instance.AddRange(RelationshipTypes.Random());
            RelationshipTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        }
    }
}
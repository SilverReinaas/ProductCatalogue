using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.RelationshipClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Tests.Archetypes.RelationshipClasses {
    [TestClass] public class RelationshipConstraintTests : CommonTests<RelationshipConstraint> {
        protected override RelationshipConstraint GetRandomObj() {
            return RelationshipConstraint.Random();
        }
        [TestMethod] public void ValidConsumerRoleTypeTest() {
            Assert.IsNull(Obj.ValidConsumerRoleType);
            var r = RoleType.Random();
            r.UniqueId = Obj.ValidConsumerRoleTypeId;
            RoleTypes.Instance.Add(r);
            Assert.AreEqual(r, Obj.ValidConsumerRoleType);
        }
        [TestMethod] public void ValidProviderRoleTypeTest() {
            Assert.IsNull(Obj.ValidProviderRoleType);
            var r = RoleType.Random();
            r.UniqueId = Obj.ValidProviderRoleTypeId;
            RoleTypes.Instance.Add(r);
            Assert.AreEqual(r, Obj.ValidProviderRoleType);
        }
        [TestMethod] public void RelationshipTypeIdTest() {
            Obj = new RelationshipConstraint();
            TestProperty(() => Obj.RelationshipTypeId, x => Obj.RelationshipTypeId = x);
        }
        [TestMethod] public void ValidConsumerRoleTypeIdTest() {
            Obj = new RelationshipConstraint();
            TestProperty(() => Obj.ValidConsumerRoleTypeId, x => Obj.ValidConsumerRoleTypeId = x);
        }
        [TestMethod] public void ValidProviderRoleTypeIdTest() {
            Obj = new RelationshipConstraint();
            TestProperty(() => Obj.ValidProviderRoleTypeId, x => Obj.ValidProviderRoleTypeId = x);
        }
        [TestMethod]
        public void RelationshipTypeTest()
        {
            Assert.IsNull(Obj.RelationshipType);
            var r = RelationshipType.Random();
            r.UniqueId = Obj.RelationshipTypeId;
            RelationshipTypes.Instance.Add(r);
            RelationshipTypes.Instance.AddRange(RelationshipTypes.Random());
            Assert.AreEqual(r, Obj.RelationshipType);
        }
    }
}

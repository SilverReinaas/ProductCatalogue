using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RelationshipClasses;
namespace Open.Tests.Archetypes.RelationshipClasses {
    [TestClass] public class RelationshipsTests : CommonTests<Relationships> {

        protected override Relationships GetRandomObj() { return Relationships.Random(); }
        [TestMethod] public void GetRoleRelationshipsTest() {
            var s = GetRandom.String();
            Assert.AreEqual(0, Relationships.GetRoleRelationships(s).Count);
            var l = Relationships.Random();
            foreach (var e in l) {
                if (GetRandom.Bool()) e.ConsumerId = s;
                else e.ProviderId = s;
            }
            Relationships.Instance.AddRange(l);
            Relationships.Instance.AddRange(Relationships.Random());
            Assert.AreEqual(l.Count, Relationships.GetRoleRelationships(s).Count);
        }
        [TestMethod] public void GetProviderRelationshipsTest() {
            var s = GetRandom.String();
            Assert.AreEqual(0, Relationships.GetProviderRelationships(s).Count);
            var l = Relationships.Random();
            foreach (var e in l) e.ProviderId = s;
            Relationships.Instance.AddRange(l);
            Relationships.Instance.AddRange(Relationships.Random());
            Assert.AreEqual(l.Count, Relationships.GetProviderRelationships(s).Count);
        }
        [TestMethod] public void GetConsumerRelationshipsTest() {
            var s = GetRandom.String();
            Assert.AreEqual(0, Relationships.GetConsumerRelationships(s).Count);
            var l = Relationships.Random();
            foreach (var e in l) e.ConsumerId = s;
            Relationships.Instance.AddRange(l);
            Relationships.Instance.AddRange(Relationships.Random());
            Assert.AreEqual(l.Count, Relationships.GetConsumerRelationships(s).Count);
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=> Relationships.Instance);
        }
    }
}

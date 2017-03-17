using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.RelationshipClasses;
namespace Open.Tests.Archetypes.RelationshipClasses
{
    [TestClass]
    public class RelationshipTypeTests: CommonTests<RelationshipType>
    {
        protected override RelationshipType GetRandomObj() {
            return RelationshipType.Random();
        }
        [TestMethod] public void ConstraintsTest() {
            Assert.AreEqual(0, Obj.Constraints.Count);
            var l = RelationshipConstraints.Random();
            foreach (var e in l) e.RelationshipTypeId = Obj.UniqueId;
            RelationshipConstraints.Instance.AddRange(l);
            RelationshipConstraints.Instance.AddRange(RelationshipConstraints.Random());
            Assert.AreEqual(l.Count, Obj.Constraints.Count);
        }
        [TestMethod] public void TypeTest() {
            Assert.IsNull(Obj.Type);
            var t = RelationshipType.Random();
            t.UniqueId = Obj.TypeId;
            RelationshipTypes.Instance.AddRange(RelationshipTypes.Random());
            RelationshipTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        } 
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RelationshipClasses;
namespace Open.Tests.Archetypes.RelationshipClasses
{
    [TestClass]
    public class RelationshipTypesTests: CommonTests<RelationshipTypes>
    {
        protected override RelationshipTypes GetRandomObj() {
            return RelationshipTypes.Random();
        }
        [TestMethod] public void FindTest() {
            var s = GetRandom.String();
            RelationshipTypes.Instance.AddRange(RelationshipTypes.Random());
            Assert.IsNull(RelationshipTypes.Find(s));
            var t = RelationshipType.Random();
            t.UniqueId = s;
            RelationshipTypes.Instance.Add(t);
            Assert.AreEqual(t, RelationshipTypes.Find(s));
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=> RelationshipTypes.Instance);
        }
    }
}

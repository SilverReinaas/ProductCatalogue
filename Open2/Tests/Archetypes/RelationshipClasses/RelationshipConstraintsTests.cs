using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RelationshipClasses;
namespace Open.Tests.Archetypes.RelationshipClasses
{
    [TestClass]
    public class RelationshipConstraintsTests : CommonTests<RelationshipConstraints>
    {
        protected override RelationshipConstraints GetRandomObj() {
            return RelationshipConstraints.Random();
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=> RelationshipConstraints.Instance);            
        }
        [TestMethod] public void GetTypeConstraintsTest() {
            var s = GetRandom.String();
            RelationshipConstraints.Instance.AddRange(RelationshipConstraints.Random());
            Assert.AreEqual(0, RelationshipConstraints.GetTypeConstraints(s).Count);
            var l = RelationshipConstraints.Random();
            foreach (var e in l) e.RelationshipTypeId = s;
            RelationshipConstraints.Instance.AddRange(l);
            Assert.AreEqual(l.Count, RelationshipConstraints.GetTypeConstraints(s).Count);
        }
    }
}

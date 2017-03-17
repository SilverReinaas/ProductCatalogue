using Open.Archetypes.BaseClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class AttributeTests : CommonTests<Attribute> {
        protected override Attribute GetRandomObj() { return Attribute.Random(); }
        [TestMethod] public void EntityIdTest() {
            Obj = new Attribute();
            TestProperty(() => Obj.EntityId, x => Obj.EntityId = x);
        }
        [TestMethod] public void TagsTest() {
            Obj = new Attribute();
            TestProperty(() => Obj.Tags, x => Obj.Tags = x);
        }
    }
}

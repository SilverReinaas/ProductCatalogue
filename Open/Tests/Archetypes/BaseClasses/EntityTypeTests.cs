using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class EntityTypeTests : CommonTests<EntityType> {
        protected override EntityType GetRandomObj() { return EntityType.Random(); }
        [TestMethod] public void TypeIdTest() {
            Obj = new EntityType();
            TestProperty(() => Obj.TypeId, x => Obj.TypeId = x);
        }
        [TestMethod] public void TypeTest() {
            Assert.IsNull(Obj.Type);
            var e = new EntityType {UniqueId = Obj.TypeId};
            EntityTypes.Instance.Add(e);
            Assert.AreEqual(e, Obj.Type);
        }
    }
}

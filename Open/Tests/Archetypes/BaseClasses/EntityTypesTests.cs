using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class EntityTypesTests : CommonTests<EntityTypes> {
        protected override EntityTypes GetRandomObj() {
            return EntityTypes.Random();
        }
        [TestMethod]
        public void FindTest()
        {
            EntityTypes.Instance.AddRange(Obj);
            var e = EntityType.Random();
            Assert.IsNull(EntityTypes.Find(e.UniqueId));
            var c = GetRandom.Int32(0, Obj.Count);
            EntityTypes.Instance.Insert(c, e);
            Assert.AreEqual(e, EntityTypes.Find(e.UniqueId));
        }
        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => EntityTypes.Instance);
        }
    }
}

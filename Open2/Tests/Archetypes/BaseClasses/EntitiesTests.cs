using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class EntitiesTests : CommonTests<Entities> {
        protected override Entities GetRandomObj() { return Entities.Random(); }
        [TestMethod] public void FindTest() {
            Entities.Instance.AddRange(Obj);
            var e = Entity.Random();
            Assert.IsNull(Entities.Find(e.UniqueId));
            var c = GetRandom.Int32(0, Obj.Count);
            Entities.Instance.Insert(c, e);
            Assert.AreEqual(e, Entities.Find(e.UniqueId));
        }
        [TestMethod] public void InstanceTest() {
            TestSingleton(()=> Entities.Instance);
        }
    }
}

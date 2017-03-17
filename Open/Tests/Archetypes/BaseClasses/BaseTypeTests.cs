using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses
{
    [TestClass]
    public class BaseTypeTests: ClassTests<BaseType<EntityType>>
    {
        private class TestClass : EntityType { }
        [TestMethod]
        public void TypeIdTest()
        {
            var o = new TestClass();
            TestProperty(() => o.TypeId, x => o.TypeId = x);
        }
        [TestMethod]
        public void TypeTest()
        {
        }
    }
}

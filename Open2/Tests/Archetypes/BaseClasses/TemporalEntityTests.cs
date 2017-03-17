using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses
{
    [TestClass]
    public class TemporalEntityTests: ClassTests<TemporalEntity>
    {
        private class TestClass: TemporalEntity { }
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new TestClass().GetType().BaseType.BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
        [TestMethod] public void ValidTest() {
            TemporalEntity o = new TestClass();
            TestProperty(()=>o.Valid, x => o.Valid = x);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses
{
    [TestClass]
    public class AttributedEntityTests: ClassTests<AttributedEntity>
    {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
        }
        [TestMethod] public void GetAttributesTest() {
            Assert.IsTrue(typeof(AttributedEntity).GetMethod("GetAttributes").IsAbstract);
        }
    }
}

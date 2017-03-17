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
        [TestMethod] public void AttributesTest() {
            Assert.IsNotNull(typeof(AttributedEntity).GetProperty("Attributes"));
        }
    }
}

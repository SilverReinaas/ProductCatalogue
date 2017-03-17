using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class AttributesTests : ClassTests<Attributes> {
        [TestMethod] public void InstanceTest() { Assert.IsNotNull(Attributes.Instance); }
    }
}

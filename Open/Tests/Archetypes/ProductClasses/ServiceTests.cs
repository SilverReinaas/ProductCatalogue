using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses {
    [TestClass] public class ServiceTests : ClassTests<Service> {
        [TestMethod] public void ConstructorTest() {
            var a = new Service().GetType().BaseType;
            Assert.AreEqual(a, typeof(Product));
        }
    }
}
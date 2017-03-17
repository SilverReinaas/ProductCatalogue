using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses {
    [TestClass] public class CanceledServiceTests : ClassTests<CanceledService> {
        [TestMethod] public void ConstructorTest() {
            var a = new CanceledService().GetType().BaseType;
            Assert.AreEqual(a, typeof(Service));
        }
    }
}
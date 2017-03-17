using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses {
    [TestClass] public class ExecutingServiceTests : ClassTests<ExecutingService> {
        [TestMethod] public void ConstructorTest() {
            var a = new ExecutingService().GetType().BaseType;
            Assert.AreEqual(a, typeof(Service));
        }
        [TestMethod] public void CompleteTest() {
            Assert.AreEqual(false, new ExecutingService().Complete());
        }
        [TestMethod] public void CancelTest() {
            Assert.AreEqual(false, new ExecutingService().Cancel());
        }
    }
}
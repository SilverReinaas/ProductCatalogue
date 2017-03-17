using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses {
    [TestClass] public class ScheduledServiceTests : ClassTests<ScheduledService> {
        [TestMethod] public void ConstructorTest() {
            var a = new ScheduledService().GetType().BaseType;
            Assert.AreEqual(a, typeof(Service));
        }
        [TestMethod] public void RescheduleTest() {
            Assert.AreEqual(false, new ScheduledService().Reschedule());
        }
        [TestMethod] public void CancelTest() {
            Assert.AreEqual(false, new ScheduledService().Cancel());
        }
        [TestMethod] public void ExecuteTest() {
            Assert.AreEqual(false, new ScheduledService().Execute());
        }
    }
}
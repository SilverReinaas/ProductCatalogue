using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class CompletedServiceTests : ClassTests<CompletedService>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new CompletedService().GetType().BaseType;
            Assert.AreEqual(a, typeof(Service));
        }
    }
}
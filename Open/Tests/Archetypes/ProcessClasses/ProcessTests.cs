using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProcessClasses;
namespace Open.Tests.Archetypes.ProcessClasses {
    [TestClass] public class ProcessTests : ClassTests<Process> {
        [TestMethod] public void ConstructorTest() {
            var a = new Process().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}
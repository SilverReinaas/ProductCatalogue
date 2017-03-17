using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class RuleTests : ClassTests<Rule> {
        [TestMethod] public void ConstructorTest() {
            var a = new Rule().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ContactClasses;
namespace Open.Tests.Archetypes.ContactClasses
{
    [TestClass]
    public class ContactTests: ClassTests<Contact>
    {
        [TestMethod]
        public void ConstructorTest() {
            var a = new Contact().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests {
    [TestClass] public class IsArchetypesTested : IsTestedBase {
        private const string assembly = "Open.Archetypes";
        protected override string Namespace(string name) { return $"{assembly}.{name}Classes"; }
        [TestMethod] public void BaseClasses() { GetMembers(assembly, Namespace("Base")); }
        [TestMethod] public void ContactClasses() { GetMembers(assembly, Namespace("Contact")); }
        [TestMethod] public void InventoryClasses() { GetMembers(assembly, Namespace("Inventory")); }
        [TestMethod] public void MoneyClasses() { GetMembers(assembly, Namespace("Money")); }
        [TestMethod] public void OrderClasses() { GetMembers(assembly, Namespace("Order")); }
        [TestMethod] public void PartyClasses() { GetMembers(assembly, Namespace("Party")); }
        [TestMethod] public void ProcessClasses() { GetMembers(assembly, Namespace("Process")); }
        [TestMethod] public void ProductClasses() { GetMembers(assembly, Namespace("Product")); }
        [TestMethod] public void QuantityClasses() { GetMembers(assembly, Namespace("Quantity")); }
        [TestMethod] public void RelationshipClasses() { GetMembers(assembly, Namespace("Relationship")); }
        [TestMethod] public void RoleClasses() { GetMembers(assembly, Namespace("Role")); }
        [TestMethod] public void RuleClasses() { GetMembers(assembly, Namespace("Rule")); }
        [TestMethod] public void ValueClasses() { GetMembers(assembly, Namespace("Value")); }
    }
}

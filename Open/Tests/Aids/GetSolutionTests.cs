using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class GetSolutionTests : ClassTests<GetSolution> {
        private const string name = "Open.Aids";
        [TestMethod] public void DomainTest() {
            var e = AppDomain.CurrentDomain;
            var a = GetSolution.Domain;
            Assert.AreEqual(e, a);
        }
        [TestMethod] public void AssembliesTest() {
            var e = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var a = GetSolution.Assemblies;
            Assert.AreEqual(e.Count, a.Count);
            foreach (var x in e)
                Assert.IsNotNull(a.Find(o => o.FullName == x.FullName));
        }
        [TestMethod] public void AssemblyTest() {
            var a = GetSolution.Assembly(name);
            var e = Assembly.Load(name);
            Assert.AreEqual(e, a);
            Assert.IsNull(GetSolution.Assembly(null));
            Assert.IsNull(GetSolution.Assembly(string.Empty));
        }
        [TestMethod] public void ClassesTest() {
            var a = GetSolution.Classes(name);
            var e = Assembly.Load(name).GetTypes().ToList();
            Assert.AreEqual(e.Count, a.Count);
            foreach (var x in a) { Assert.IsTrue(e.Contains(x)); }
        }
        [TestMethod] public void ClassesNamesTest() {
            var a = GetSolution.ClassesNames(name);
            var e =
                Assembly.Load(name).GetTypes().Select(t => t.FullName).ToList();
            Assert.AreEqual(e.Count, a.Count);
            foreach (var x in a) { Assert.IsTrue(e.Contains(x)); }
        }
        [TestMethod] public void NameTest() {
            Assert.AreEqual("Open", GetSolution.Name);
        }
    }
}

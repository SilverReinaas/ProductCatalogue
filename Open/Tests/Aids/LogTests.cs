using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class LogTests : ClassTests<Log> {
        private static string Message => GetRandom.String();
        [TestMethod] public void ClearTest() { }
        [TestMethod] public void EntriesTest() {
            var count = Log.Entries.Count;
            Log.Exception(new NotImplementedException());
            Assert.AreEqual(count + 1, Log.Entries.Count);
        }
        [TestMethod] public void ErrorTest() {
            var count = Log.Entries.Count;
            Log.Error(GetRandom.String());
            Assert.AreEqual(count + 1, Log.Entries.Count);
        }
        [TestMethod] public void ExceptionTest() { }
        [TestMethod] public void InstanceTest() {
            Assert.IsInstanceOfType(Log.Instance, typeof(EventLog));
        }
        [TestMethod] public void MessageTest() {
            var s = Message;
            var e = new NotImplementedException(s);
            var m = Log.Message(e);
            Assert.IsTrue(m.StartsWith("Source: "));
            Assert.IsTrue(m.Contains("\nHResult: "));
            Assert.IsTrue(m.Contains($"\nMessage: {s}"));
            Assert.IsTrue(m.Contains("\nStackTrace: "));
        }
        [TestMethod] public void SourceTest() {
            Assert.AreEqual(GetSolution.Name, Log.Source);
        }
    }
}

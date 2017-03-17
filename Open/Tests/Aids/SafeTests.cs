using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class SafeTests : ClassTests<Safe> {
        [TestMethod] public void RunTest() {
            var a = Safe.Run(() => { throw new Exception(); }, false);
            Assert.AreEqual(false, a);
        }
        [TestMethod] public void RunActionTest() {
            Safe.Run(() => { throw new Exception(); });
        }
    }
}

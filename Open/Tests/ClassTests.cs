using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;

namespace Open.Tests {
    public class ClassTests<T> : PropertyTests {
        internal int TestSleepingTime { get; set; } = 50;
        internal const string NotTested = "<{0}> is not tested";
        protected List<string> Members { get; set; }
        [TestInitialize] public virtual void TestInitialize() { }
        [TestCleanup] public virtual void TestCleanup() { }
        [TestMethod] public virtual void IsTested() {
            var t = typeof(T);
            var m = GetClass.Members(t, GetPublic.Declared);
            Members = m.Select(e => e.Name).ToList();
            RemoveTested();
            if (Members.Count == 0) return;
            Assert.Inconclusive(NotTested, Members[0]);
        }
        private void RemoveTested() {
            var tests = GetType().GetMembers().Select(e => e.Name).ToList();
            for (var i = Members.Count; i > 0; i--) {
                var m = Members[i - 1] + "Test";
                var isTested = tests.Find(o => o == m);
                if (string.IsNullOrEmpty(isTested)) continue;
                Members.RemoveAt(i - 1);
            }
        }
        protected void IsNotEqualTest<TK>(Func<TK> get){
            var x = get();
            var y = get();
            while (x.Equals(y)) y = get();
            Assert.AreNotEqual(x, y);
        }
        protected void IsEqualTest<TK>(Func<TK> get) {
            Assert.AreEqual(get(), get());
        }
        protected void IsEqualTest<TK>(TK value, Func<TK> get) {
            Assert.AreEqual(value, get());
        }
    }
}

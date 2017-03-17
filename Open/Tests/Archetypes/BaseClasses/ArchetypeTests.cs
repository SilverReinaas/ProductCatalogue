using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses {
    [TestClass] public class ArchetypeTests : ClassTests<Archetype> {
        private class TestClass: Archetype {}
        private object obj;
        private object oldValue;
        private object newValue;
        private Archetype o;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            o = new TestClass();
        }
        [TestMethod] public void CallingMethodTest() {
            Assert.AreEqual("InvokeMethod", Archetype.CallingMethod());
            Assert.AreEqual("Method2", Method3());
        }
        private static string Method1() { return Archetype.CallingMethod(); }
        private static string Method2() { return Method1(); }
        private static string Method3() { return Method2(); }
        [TestMethod] public void ConstructorTest() {
            Assert.AreEqual(o.GetType().BaseType.BaseType, typeof(Common));
        }
        [TestMethod] public void SetStringTest() {
            var s1 = GetRandom.String();
            var s2 = GetRandom.String();
            var s = s1;
            o.SetValue(ref s, null);
            Assert.AreEqual(s1, s);
            o.SetValue(ref s, s2);
            Assert.AreEqual(s2, s);
        }
        [TestMethod] public void SetValueTest() {
            var a1 = new TestClass();
            var a2 = new TestClass();
            var a = a1;
            o.SetValue(ref a, null);
            Assert.AreEqual(a1, a);
            o.SetValue(ref a, a2);
            Assert.AreEqual(a2, a);
        }
        [TestMethod] public void SetDefaultTest() {
            var a1 = new TestClass();
            TestClass a = null;
            o.SetDefault(ref a);
            Assert.IsNotNull(a);
            a = null;
            o.SetDefault(ref a, a1);
            Assert.AreEqual(a1, a);
        }
        [TestMethod] public void OnChangedTest() {
            o.OnChanged += OnChangedInvoked;
            var a1 = new TestClass();
            var a2 = new TestClass();
            var a = a1;
            o.SetValue(ref a, a1);
            Assert.IsNull(obj);
            o.SetValue(ref a, a2);
            Assert.AreEqual(obj, o);
            Assert.AreEqual(oldValue, a1);
            Assert.AreEqual(newValue, a2);
        }
        private void OnChangedInvoked(object sender, ValueChangedEventArgs e) {
            obj = sender;
            oldValue = e.OldValue;
            newValue = e.NewValue;
        }
        [TestMethod] public void SetIfEmptyTest() { }
        [TestMethod] public void ChangeIfUnvaluedTest() {
            Action<string, string, string, string> test = (a, b, c, d) => {
                o.ChangeIfUnvalued(ref a, b, c);
                Assert.AreEqual(a, d);
            }; 
            var s1 = GetRandom.String();
            var s2 = GetRandom.String();
            var s = s1;
            test(s, null, null, s1);
            test(s, s2, s2, s1);
            test(s, GetRandom.String(), s2, s1);
            s = null;
            test(s, s2, s2, null);
            test(s, GetRandom.String(), s2, s2);
        }
        [TestMethod] public void CloneTest() { }
    }
}

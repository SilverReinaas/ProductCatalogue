using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class ValueChangedEventArgsTests :
        ClassTests<ValueChangedEventArgs> {
        private ValueChangedEventArgs obj;
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new ValueChangedEventArgs();
        }
        [TestMethod] public void ConstructorTest() {
            Assert.AreEqual(obj.GetType().BaseType, typeof(EventArgs));
        }
        [TestMethod] public void OldValueTest() {
            Assert.IsNull(obj.OldValue);
            var s = GetRandom.String();
            obj.OldValue = s;
            Assert.AreEqual(s, obj.OldValue);
        }
        [TestMethod] public void NewValueTest() {
            Assert.IsNull(obj.NewValue);
            var s = GetRandom.String();
            obj.NewValue = s;
            Assert.AreEqual(s, obj.NewValue);
        }
        [TestMethod] public void MethodNameTest() {
            Assert.IsNull(obj.MethodName);
            var s = GetRandom.String();
            obj.MethodName = s;
            Assert.AreEqual(s, obj.MethodName);
        }
        [TestMethod] public void IndexTest() {
            Assert.AreEqual(0, obj.Index);
            var i = GetRandom.Int32();
            obj.Index = i;
            Assert.AreEqual(i, obj.Index);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests {
    public class PropertyTests : Serializable {
        protected void TestProperty(Func<string> get, Action<string> set) {
            Assert.AreEqual(string.Empty, get());
            var s = Open.Aids.GetRandom.String();
            set(s);
            Assert.AreEqual(s, get());
            set(null);
            Assert.AreEqual(s, get());
        }
        protected void TestProperty<T>(Func<T> get, Action<T> set) where T : new() {
            Assert.IsNotNull(get());
            Assert.IsInstanceOfType(get(), typeof(T));
            var a1 = get();
            var a2 = new T();
            set(a2);
            Assert.AreEqual(a2, get());
            Assert.AreNotEqual(a1, get());
            set(default(T));
            Assert.IsNotNull(get());
        }
        public void TestProperty(Func<DateTime> get, Action<DateTime> set, DateTime initialValue) {
            Assert.AreEqual(initialValue, get());
            var s = Open.Aids.GetRandom.DateTime();
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<bool> get, Action<bool> set, bool initialValue) {
            Assert.AreEqual(initialValue, get());
            var s = !initialValue;
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<double> get, Action<double> set, double initialValue) {
            Assert.AreEqual(initialValue, get());
            var s = Open.Aids.GetRandom.Double();
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<decimal> get, Action<decimal> set, decimal initialValue)
        {
            Assert.AreEqual(initialValue, get());
            var s = Open.Aids.GetRandom.Decimal();
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<int> get, Action<int> set, int initialValue) {
            Assert.AreEqual(initialValue, get());
            var s = Open.Aids.GetRandom.Int32();
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<uint> get, Action<uint> set, uint initialValue) {
            Assert.AreEqual(initialValue, get());
            var s = Open.Aids.GetRandom.UInt32();
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestEnumProperty<T>(Func<T> get, Action<T> set) {
            Assert.IsTrue(typeof(T).IsEnum);
            var i = Open.Aids.GetEnum.Value<T>(0);
            Assert.AreEqual(i, get());
            var s = Open.Aids.GetRandom.Enum< T>();
            set(s);
            Assert.AreEqual(s, get());
        }
        protected void TestSingleton<T>(Func<T> get) {
            var s = get();
            Assert.IsNotNull(s);
            Assert.AreEqual(s, get());
        }
    }
}

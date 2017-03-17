using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests {
    public abstract class CommonTests<T> : ClassTests<T> where T : Common, new() {
        protected T Obj { get; set; }
        private object obj;
        private ValueChangedEventArgs args;
        protected abstract T GetRandomObj();
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            Obj = GetRandomObj();
            ClearDoOnChanged();
        }
        [TestCleanup] public override void TestCleanup() {
            base.TestCleanup();
            Obj = default(T);
            ClearDoOnChanged();
        }
        [TestMethod] public void FromJsonTest() {
            ToFromJsonTest(new T());
            ToFromJsonTest(GetRandomObj());
        }
        [TestMethod] public virtual void IsEqualTest() {
            var a = GetRandomObj();
            var b = a;
            Assert.IsTrue(a.IsEqual(b));
        }
        [TestMethod] public void IsSameContentTest() {
            var a = GetRandomObj();
            var s = a.ToString();
            var b = Json.From<T>(s);
            Assert.IsTrue(a.IsSameContent(b));
        }
        [TestMethod] public void ToJsonTest() { FromJsonTest(); }
        [TestMethod] public void ParseTest() {
            var a = GetRandomObj();
            var s = a.ToString();
            var b = Common.Parse<T>(s);
            Assert.IsTrue(a.IsSameContent(b));
        }
        [TestMethod] public void TryParseTest() {
            var a = GetRandomObj();
            var s = a.ToString();
            T b;
            Assert.IsTrue(Common.TryParse(s, out b));
            Assert.IsTrue(a.IsSameContent(b));
        }
        [TestMethod] public virtual void RandomTest() {
            var x = GetRandomObj();
            var y = GetRandomObj();
            while (ToJson(x) == ToJson(y)) 
                y = GetRandomObj();
            Assert.IsNotNull(x);
            Assert.AreEqual(x.GetType(), typeof(T));
            Assert.AreNotEqual(ToJson(x), ToJson(y));
        }
        [TestMethod] public void ToStringTest() {
            ToStringTest(new T());
            ToStringTest(GetRandomObj());
        }
        [TestMethod] public virtual void XmlSerializationTest() {
            ToFromXmlTest(new T());
            ToFromXmlTest(GetRandomObj());
        }
        private static void ToStringTest(T o) {
            var expected = ToJson(o);
            var actual = o.ToString();
            Assert.AreEqual(expected, actual);
        }
        private static void ToFromXmlTest(T o) {
            var expected = ToXml(o);
            var x = FromXml<T>(expected);
            var actual = ToXml(x);
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(expected));
            if (!(o is IEnumerable))
                IsPublicPropertiesSerialized(x, expected);
        }
        private static void ToFromJsonTest(T o) {
            var expected = ToJson(o);
            var x = FromJson<T>(expected);
            var actual = ToJson(x);
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(expected));
            if (!(o is IEnumerable))
                IsPublicPropertiesSerialized(x, expected);
        }
        protected void ClearDoOnChanged() {
            obj = null;
            args = null;
        }
        protected void DoOnChanged(object sender, ValueChangedEventArgs e) {
            obj = sender;
            args = e;
        }
        protected void TestDoOnChange(string method, object newValue, object oldValue, int index) {
            Assert.AreEqual(Obj, obj);
            Assert.IsTrue(args.MethodName.Contains(method));
            Assert.AreEqual(newValue, args.NewValue);
            Assert.AreEqual(oldValue, args.OldValue);
            Assert.AreEqual(index, args.Index);
        }
        protected void TestDoOnChange() {
            Assert.IsNull(obj);
            Assert.IsNull(args);
        }
        private static void IsPublicPropertiesSerialized(object o, string s) {
            Assert.IsNotNull(o);
            Assert.IsNotNull(s);
            var properties = GetClass.Properties(o.GetType());
            foreach (var p in properties) {
                if (!p.CanRead) continue;
                if (!p.CanWrite) continue;
                var n = p.Name;
                Assert.IsTrue(s.Contains(n), n);
            }
        }
    }
}

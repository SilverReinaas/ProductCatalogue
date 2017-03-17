using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.BaseClasses
{
    [TestClass]
    public class ArchetypesTests: CommonTests<Archetypes<string>>
    {
        protected override Archetypes<string> GetRandomObj() {
            var a = new Archetypes<string>();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) a.Add(GetRandom.String());
            return a;
        }
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            Obj.OnChanged += DoOnChanged;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(Obj.GetType().BaseType, typeof(Archetype));
            Assert.IsInstanceOfType(Obj, typeof(IList<string>));
        }
        [TestMethod]
        public void GetEnumeratorTest()
        {
            Assert.IsNotNull(Obj.GetEnumerator());
            TestDoOnChange();
        }
        [TestMethod]
        public void AddTest()
        {
            var s = GetRandom.String();
            Obj.AddRange(GetRandom.Strings());
            var c = Obj.Count;
            Obj.Add(s);
            TestDoOnChange("Add", s, null, 0);
            Assert.AreEqual(c + 1, Obj.Count);
        }
        [TestMethod]
        public void IsSetTest()
        {
            Obj = new Archetypes<string> { IsSet = true };
            Obj.Add("A");
            Assert.AreEqual(1, Obj.Count);
            Obj.Add("A");
            Assert.AreEqual(1, Obj.Count);
            Obj.Insert(0, "B");
            Assert.AreEqual(2, Obj.Count);
            Obj.Insert(0, "B");
            Assert.AreEqual(2, Obj.Count);
            Obj.AddRange(new List<string> { "C", "D" });
            Assert.AreEqual(4, Obj.Count);
            Obj.AddRange(new List<string> { "C", "D", "E" });
            Assert.AreEqual(5, Obj.Count);
        }
        [TestMethod]
        public void AddRangeTest()
        {
            var a = GetRandom.Strings().ToList();
            Obj.AddRange(a);
            TestDoOnChange("AddRange", a, null, 0);
        }
        [TestMethod]
        public void AsReadOnlyTest()
        {
            var o = Obj.AsReadOnly();
            Assert.IsTrue(o.IsReadOnly);
            TestDoOnChange();
            Assert.AreEqual(o.Count, Obj.Count);
            for (var i = 0; i < o.Count; i++)
                Assert.AreEqual(o[i], Obj[i]);
            TestDoOnChange();
        }
        [TestMethod]
        public void ClearTest()
        {
            AddTest();
            Assert.AreNotEqual(0, Obj.Count);
            ClearDoOnChanged();
            Obj.Clear();
            TestDoOnChange("Clear", null, null, 0);
            Assert.AreEqual(0, Obj.Count);
        }
        [TestMethod]
        public void ContainsTest()
        {
            AddTest();
            var s = GetRandom.String();
            Assert.IsFalse(Obj.Contains(s));
            Obj.Add(s);
            ClearDoOnChanged();
            Assert.IsTrue(Obj.Contains(s));
            TestDoOnChange();
        }
        [TestMethod]
        public void CopyToTest()
        {
            AddTest();
            ClearDoOnChanged();
            var a = new string[Obj.Count];
            Obj.CopyTo(a, 0);
            for (var i = 0; i < a.Length; i++)
                Assert.AreEqual(a[i], Obj[i]);
            TestDoOnChange();
        }
        [TestMethod]
        public void CountTest()
        {
            Obj = new Archetypes<string>();
            Assert.AreEqual(0, Obj.Count);
            TestDoOnChange();
        }
        [TestMethod]
        public void DefaultValueTest()
        {
            Assert.AreEqual(null, Obj.DefaultValue());
        }
        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Func<string> test =
                () => Obj.Find(o => o.StartsWith(s.Substring(0, 10)));
            AddTest();
            var a = test();
            Assert.IsNull(a);
            Obj.Add(s);
            a = test();
            Assert.AreEqual(s, a);
        }
        [TestMethod]
        public void FindLastTest()
        {
            var s1 = GetRandom.String();
            var s2 = s1 + GetRandom.String();
            Func<string> test =
                () => Obj.FindLast(o => o.StartsWith(s1.Substring(0, 10)));
            AddTest();
            var a = test();
            Assert.IsNull(a);
            Obj.Insert(0, s1);
            Obj.Add(s2);
            a = test();
            Assert.AreEqual(s2, a);
        }
        [TestMethod]
        public void FindAllTest()
        {
            var s1 = GetRandom.String();
            var s2 = s1 + GetRandom.String();
            AddTest();
            Func<Archetypes<string>> test =
                () => Obj.FindAll(o => o.StartsWith(s1.Substring(0, 10)));
            var a = test();
            Assert.AreEqual(0, a.Count);
            Obj.Insert(0, s1);
            Obj.Add(s2);
            a = test();
            Assert.AreEqual(2, a.Count);
            Assert.AreEqual(s1, a[0]);
            Assert.AreEqual(s2, a[1]);
        }
        [TestMethod]
        public void FindIndexTest()
        {
            AddTest();
            var s = GetRandom.String();
            var a = Obj.FindIndex(o => o.StartsWith(s.Substring(0, 10)));
            Assert.AreEqual(-1, a);
            var i = GetRandom.Int32(0, Obj.Count - 1);
            Obj.Insert(i, s);
            a = Obj.FindIndex(o => o.StartsWith(s.Substring(0, 10)));
            Assert.AreEqual(i, a);
        }
        [TestMethod]
        public void FindLastIndexTest()
        {
            var s1 = GetRandom.String();
            var s2 = s1 + GetRandom.String();
            Func<int> test =
                () => Obj.FindLastIndex(o => o.StartsWith(s1.Substring(0, 10)));
            AddTest();
            var a = test();
            Assert.AreEqual(-1, a);
            Obj.Insert(0, s1);
            Obj.Add(s2);
            a = test();
            Assert.AreEqual(Obj.Count - 1, a);
        }
        [TestMethod]
        public void GetTest()
        {
            var s1 = GetRandom.String();
            var s2 = s1 + GetRandom.String();
            AddTest();
            Obj.Insert(0, s1);
            Obj.Add(s2);
            Assert.AreEqual(s1, Obj.Get(0));
            Assert.AreEqual(s2, Obj.Get(Obj.Count - 1));
            Assert.AreEqual(null, Obj.Get(Obj.Count));
        }
        [TestMethod]
        public void IsReadOnlyTest()
        {
            Assert.IsFalse(Obj.IsReadOnly);
            TestDoOnChange();
        }
        [TestMethod]
        public void IndexOfTest()
        {
            AddTest();
            var s = GetRandom.String();
            Assert.AreEqual(-1, Obj.IndexOf(s));
            Obj.Add(s);
            ClearDoOnChanged();
            Assert.AreEqual(Obj.Count - 1, Obj.IndexOf(s));
            TestDoOnChange();
        }
        [TestMethod]
        public void InsertTest()
        {
            AddTest();
            ClearDoOnChanged();
            var s = GetRandom.String();
            var c = GetRandom.UInt8(0, (byte)(Obj.Count - 1));
            Obj.Insert(c, s);
            TestDoOnChange("Insert", s, null, c);
        }
        [TestMethod]
        public void IsCorrectIndexTest()
        {
            Obj = new Archetypes<string>();
            Obj.OnChanged += DoOnChanged;
            Assert.IsFalse(Obj.IsCorrectIndex(0));
            TestDoOnChange();
            AddTest();
            ClearDoOnChanged();
            Assert.IsFalse(Obj.IsCorrectIndex(GetRandom.Int32(max: -1)));
            Assert.IsFalse(Obj.IsCorrectIndex(GetRandom.Int32(2)));
            Assert.IsTrue(Obj.IsCorrectIndex(0));
            Assert.IsTrue(Obj.IsCorrectIndex(1));
            TestDoOnChange();
        }
        [TestMethod]
        public void RemoveTest()
        {
            AddTest();
            ClearDoOnChanged();
            var c = GetRandom.Int32(0, Obj.Count - 1);
            var s = Obj[c];
            Assert.IsNotNull(s);
            Obj.Remove(s);
            TestDoOnChange("Remove", null, s, c);
        }
        [TestMethod]
        public void RemoveAtTest()
        {
            AddTest();
            ClearDoOnChanged();
            var c = GetRandom.Int32(0, Obj.Count - 1);
            var s = Obj[c];
            Assert.IsNotNull(s);
            Obj.RemoveAt(c);
            TestDoOnChange("RemoveAt", null, s, c);
        }
        [TestMethod]
        public void ItemTest()
        {
            AddTest();
            ClearDoOnChanged();
            var c = GetRandom.Int32(0, Obj.Count - 1);
            var old = Obj[c];
            Assert.IsNotNull(old);
            TestDoOnChange();
            var s = GetRandom.String();
            Obj[c] = s;
            TestDoOnChange("set_Item", s, old, c);
        }
    }
}

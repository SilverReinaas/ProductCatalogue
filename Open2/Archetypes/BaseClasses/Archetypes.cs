using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public class Archetypes<T> : Archetype, IList<T> {
        protected internal readonly List<T> list = new List<T>();
        protected bool isAddReange;
        public Archetypes() : this(null) { }
        public Archetypes(IEnumerable<T> elements) {
            if (IsNull(elements)) return;
            AddRange(elements);
        }
        public IEnumerator<T> GetEnumerator() { return list.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        protected virtual bool IsThis(T x, T y) {
            if (IsNull(x)) return false;
            if (IsNull(y)) return false;
            var x1 = x as Archetype;
            var y1 = y as Archetype;
            if (!IsNull(x1) && !IsNull(y1)) return x1.IsSameContent(y1);
            return x.Equals(y);
        }
        public virtual void Add(T item) {
            Safe.Run(() => {
                if (IsReadOnly) return;
                if (IsSet && !IsNull(Find(x => IsThis(x, item)))) return;
                list.Add(item);
                if (isAddReange) return;
                DoOnChanged(item);
            });
        }
        public void AddRange(IEnumerable<T> a) { AddRange(a.ToList()); }
        public virtual void AddRange(IList<T> a) {
            Safe.Run(() => {
                isAddReange = true;
                foreach (var e in a) Add(e);
                isAddReange = false;
                DoOnChanged(a);
            });
        }
        public Archetypes<T> AsReadOnly() {
            return Safe.Run(() => {
                var l = new Archetypes<T>();
                l.AddRange(this);
                l.IsReadOnly = true;
                return l;
            }, new Archetypes<T>());
        }
        public void Clear() {
            Safe.Run(() => {
                if (IsReadOnly) return;
                list.Clear();
                DoOnChanged();
            });
        }
        public bool Contains(T item) { return Safe.Run(() => list.Contains(item), false); }
        public bool Contains(Predicate<T> match) { return !IsNull(Find(match)); }
        public void CopyTo(T[] array, int arrayIndex) {
            Safe.Run(() => list.CopyTo(array, arrayIndex));
        }
        public int Count => list.Count;
        public virtual T DefaultValue() { return default(T); }
        public T Find(Predicate<T> match) { return list.Find(match); }
        public T FindLast(Predicate<T> match) { return list.FindLast(match); }
        public Archetypes<T> FindAll(Predicate<T> match) {
            return Safe.Run(() => {
                var l = list.FindAll(match);
                var r = new Archetypes<T>();
                r.AddRange(l);
                return r;
            }, new Archetypes<T>());
        }
        public int FindIndex(Predicate<T> match) {
            return Safe.Run(() => list.FindIndex(match), -1);
        }
        public int FindLastIndex(Predicate<T> match) {
            return Safe.Run(() => list.FindLastIndex(match), -1);
        }
        public T Get(int idx) { return Safe.Run(() => this[idx], DefaultValue()); }
        public bool IsReadOnly { get; protected internal set; }
        public bool IsSet { get; protected internal set; }
        public int IndexOf(T item) { return Safe.Run(() => list.IndexOf(item), -1); }
        public virtual void Insert(int index, T item) {
            Safe.Run(() => {
                if (IsReadOnly) return;
                if (IsSet && !IsNull(Find(x => IsThis(x, item)))) return;
                if (index >= list.Count) index = list.Count - 1;
                if (index < 0) index = 0;
                list.Insert(index, item);
                DoOnChanged(index, item);
            });
        }
        public bool IsCorrectIndex(int index) {
            return Safe.Run(() => {
                if (index < 0) return false;
                return index < list.Count;
            }, false);
        }
        public bool Remove(T item) {
            return Safe.Run(() => {
                if (IsReadOnly) return false;
                if (!Contains(item)) return false;
                var i = IndexOf(item);
                var r = list.Remove(item);
                if (isAddReange) return r;
                if (r) DoOnChanged(i, item, default(T));
                return r;
            }, false);
        }
        public void RemoveAt(int index) {
            Safe.Run(() => {
                if (IsReadOnly) return;
                if (!IsCorrectIndex(index)) return;
                var e = this[index];
                list.RemoveAt(index);
                DoOnChanged(index, e, default(T));
            });
        }
        public virtual T this[int index] {
            get {
                return Safe.Run(() => IsCorrectIndex(index) ? list[index] : default(T), default(T));
            }
            set {
                Safe.Run(() => {
                    if (!IsCorrectIndex(index)) return;
                    var o = list[index];
                    list[index] = value;
                    DoOnChanged(index, o, value);
                });
            }
        }
    }
}

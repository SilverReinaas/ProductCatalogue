using System;
using System.ComponentModel;
using Open.Aids;
namespace Open.Archetypes.RuleClasses {
    public abstract class Variable<T> : Operand where T : IComparable {
        public const int Equal = 0;
        public const int Greater = 1;
        public const int Less = -1;
        protected T valueField;
        protected Variable() : this(string.Empty) { }
        protected Variable(string name, T value = default(T)) : base(name) { valueField = value; }
        public virtual T Value {
            get { return SetDefault(ref valueField, default(T)); }
            set { SetValue(ref valueField, value); }
        }
        public override bool IsOperand() { return false; }
        public override bool IsVariable() { return true; }
        public virtual bool IsEqual(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) == Equal, false);
        }
        public virtual bool IsNotEqual(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) != Equal, false);
        }
        public virtual bool IsGreater(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) == Greater, false);
        }
        public virtual bool IsNotGreater(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) != Greater, false);
        }
        public virtual bool IsLess(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) == Less, false);
        }
        public virtual bool IsNotLess(T variable) {
            return Safe.Run(() => Value.CompareTo(variable) != Less, false);
        }
        public bool IsEqual(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsEqual(v.Value), false);
        }
        public bool IsNotEqual(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsNotEqual(v.Value), false);
        }
        public bool IsGreater(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsGreater(v.Value), false);
        }
        public bool IsNotGreater(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsNotGreater(v.Value), false);
        }
        public bool IsLess(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsLess(v.Value), false);
        }
        public bool IsNotLess(Variable<T> v) {
            return Safe.Run(() => !IsNull(v) && IsNotLess(v.Value), false);
        }
        public virtual T Convert(string s) {
            return Safe.Run(() => {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                return (T) converter.ConvertFromString(s);
            }, default(T));
        }
    }
}

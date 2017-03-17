using System;
using System.Diagnostics;
using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public abstract class Archetype : Common {
        public event EventHandler<ValueChangedEventArgs> OnChanged;
        public void SetValue<T>(ref T variable, T value) {
            if (IsNull(value)) return;
            if (value.Equals(variable)) return;
            var old = variable;
            variable = value;
            if (old == null) return;
            if (old.Equals(default(T))) return;
            DoOnChanged(old, value);
        }
        public void ChangeIfUnvalued<T>(ref T variable, T def, T value) {
            if (IsNull(value)) return;
            if (value.Equals(def)) return;
            if (!IsNull(variable) && !variable.Equals(def)) return;
            SetValue(ref variable, value);
        }
        protected void DoOnChanged<T>(T oldValue, T newValue) {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                OldValue = oldValue,
                NewValue = newValue
            };
            OnChanged(this, e);
        }
        protected void DoOnChanged<T>(T newValue) {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {MethodName = CallingMethod(), NewValue = newValue};
            OnChanged(this, e);
        }
        protected void DoOnChanged<T>(int index, T newValue) {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                Index = index,
                NewValue = newValue
            };
            OnChanged(this, e);
        }
        protected void DoOnChanged<T>(int index, T oldValue, T newValue) {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                Index = index,
                OldValue = oldValue,
                NewValue = newValue
            };
            OnChanged(this, e);
        }
        protected void DoOnChanged(int index) {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {MethodName = CallingMethod(), Index = index};
            OnChanged(this, e);
        }
        protected void DoOnChanged() {
            if (OnChanged == null) return;
            var e = new ValueChangedEventArgs {MethodName = CallingMethod()};
            OnChanged(this, e);
        }
        public T SetDefault<T>(ref T variable, T value) {
            if (IsNull(variable)) SetValue(ref variable, value);
            return variable;
        }
        public T SetDefault<T>(ref T variable) where T : new() {
            if (IsNull(variable)) SetValue(ref variable, new T());
            return variable;
        }
        public string SetDefault(ref string variable) {
            if (IsNull(variable)) SetValue(ref variable, string.Empty);
            return variable;
        }
        protected virtual void SetRandomValues() { }
        public static string CallingMethod() {
            return Safe.Run(() => {
                var stack = new StackTrace();
                var frames = stack.GetFrames();
                int i;
                for (i = 0; i < stack.FrameCount; i++) {
                    var f = frames[i];
                    var m = f.GetMethod();
                    var n = m.Name;
                    if (n == "CallingMethod") break;
                }
                return frames[i + 2].GetMethod().Name;
            }, string.Empty);
        }
        public static T Clone<T>(T obj) where T: Serializable, new() {
            var s = ToJson(obj);
            return FromJson<T>(s);
        }
    }
}

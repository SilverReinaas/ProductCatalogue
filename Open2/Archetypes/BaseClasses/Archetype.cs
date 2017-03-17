using System;
using System.Diagnostics;
using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public abstract class Archetype : Common {
        protected bool isChanged;
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
        private void DoOnChanged(ValueChangedEventArgs args) {
            isChanged = true;
            OnChanged?.Invoke(this, args);
        }
        protected void DoOnChanged<T>(T oldValue, T newValue) {
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                OldValue = oldValue,
                NewValue = newValue
            };
            DoOnChanged(e);
        }
        protected void DoOnChanged<T>(T newValue) {
            var e = new ValueChangedEventArgs {MethodName = CallingMethod(), NewValue = newValue};
            DoOnChanged(e);
        }
        protected void DoOnChanged<T>(int index, T newValue) {
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                Index = index,
                NewValue = newValue
            };
            DoOnChanged( e);
        }
        protected void DoOnChanged<T>(int index, T oldValue, T newValue) {
            var e = new ValueChangedEventArgs {
                MethodName = CallingMethod(),
                Index = index,
                OldValue = oldValue,
                NewValue = newValue
            };
            DoOnChanged( e);
        }
        protected void DoOnChanged(int index) {
            var e = new ValueChangedEventArgs {MethodName = CallingMethod(), Index = index};
            DoOnChanged(e);
        }
        protected void DoOnChanged() {
            var e = new ValueChangedEventArgs {MethodName = CallingMethod()};
            DoOnChanged(e);
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
    }
}

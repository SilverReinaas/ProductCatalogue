using System;
namespace Open.Aids {
    public class ValueChangedEventArgs : EventArgs {
        public string MethodName { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
        public int Index { get; set; }
    }
}

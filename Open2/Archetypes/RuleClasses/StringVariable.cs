using System;
namespace Open.Archetypes.RuleClasses {
    public class StringVariable : Variable<string> {
        public new static StringVariable Empty { get; } = new StringVariable();
        public override string Value {
            get { return SetDefault(ref valueField); }
            set { SetValue(ref valueField, value); }
        }
        public override bool IsEmpty() { return Equals(Empty); }
        public override bool IsEqual(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) == Equal;
        }
        public override bool IsNotEqual(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) != Equal;
        }
        public override bool IsGreater(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) == Greater;
        }
        public override bool IsNotGreater(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) != Greater;
        }
        public override bool IsLess(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) == Less;
        }
        public override bool IsNotLess(string variable) {
            return string.Compare(Value, variable, StringComparison.InvariantCulture) != Less;
        }
        public new static StringVariable Random() {
            var x = new StringVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.String();
        }
    }
}

namespace Open.Archetypes.RuleClasses {
    public class DoubleVariable : Variable<double> {
        public DoubleVariable() : this(string.Empty) { }
        public DoubleVariable(string name, double value = 0.0) : base(name, value) { }
        public new static DoubleVariable Empty { get; } = new DoubleVariable();
        public override bool IsEmpty() { return Equals(Empty); }
        public new static DoubleVariable Random() {
            var x = new DoubleVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.Double(int.MinValue, int.MaxValue);
        }
    }
}

namespace Open.Archetypes.RuleClasses {
    public class DecimalVariable : Variable<decimal> {
        public DecimalVariable() : this(string.Empty) { }
        public DecimalVariable(string name, decimal value = 0.0M) : base(name, value) { }
        public new static DoubleVariable Empty { get; } = new DoubleVariable();
        public override bool IsEmpty() { return Equals(Empty); }
        public new static DecimalVariable Random() {
            var x = new DecimalVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.Decimal();
        }
    }
}

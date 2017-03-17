namespace Open.Archetypes.RuleClasses {
    public class IntegerVariable : Variable<int> {
        public new static IntegerVariable Empty { get; } = new IntegerVariable();
        public override bool IsEmpty() { return Equals(Empty); }
        public new static IntegerVariable Random() {
            var x = new IntegerVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.Int32();
        }
    }
}

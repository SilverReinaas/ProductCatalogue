namespace Open.Archetypes.RuleClasses {
    public class BooleanVariable : Variable<bool> {
        public new static BooleanVariable Empty { get; } = new BooleanVariable();
        public override bool IsEmpty() { return Equals(Empty); }
        public new static BooleanVariable Random() {
            var x = new BooleanVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.Bool();
        }
    }
}

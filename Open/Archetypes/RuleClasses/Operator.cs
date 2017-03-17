namespace Open.Archetypes.RuleClasses {
    public class Operator : RuleElement {
        private Operation operation;
        public Operator() : this(Operation.Dummy) { }
        public Operator(Operation o) { operation = o; }
        public Operation Operation {
            get { return SetDefault(ref operation); }
            set { SetValue(ref operation, value); }
        }
        public static Operator Empty { get; } = new Operator();
        public override bool IsEmpty() { return Equals(Empty); }
        public override string Name { get { return Operation.ToString(); } set { } }
        public override bool IsOperator() { return true; }
        public static Operator Random() {
            var x = new Operator();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            operation = Aids.GetRandom.Enum<Operation>();
        }
    }
}

using System;
namespace Open.Archetypes.RuleClasses {
    public class Operand : RuleElement {
        public Operand() : this(string.Empty) { }
        public Operand(string name) : base(name) { }
        public static Operand Empty { get; } = new Operand();
        public override bool IsEmpty() { return Equals(Empty); }
        public override bool IsOperand() { return true; }
        public static Operand Random() {
            var x = new Operand();
            x.SetRandomValues();
            return x;
        }
        public static Operand ToVariable(string name, object value) {
            return new StringVariable {Name = name, Value = value.ToString()};
        }
        public static Operand ToVariable(string name, int value) {
            return new IntegerVariable {Name = name, Value = value};
        }
        public static Operand ToVariable(string name, string value) {
            return new StringVariable {Name = name, Value = value};
        }
        public static Operand ToVariable(string name, decimal value) {
            return new DecimalVariable {Name = name, Value = value};
        }
        public static Operand ToVariable(string name, DateTime value) {
            return new DateTimeVariable {Name = name, Value = value};
        }
        public static Operand ToVariable(string name, bool value) {
            return new BooleanVariable {Name = name, Value = value};
        }
        public static Operand ToVariable(string name, double value) {
            return new DoubleVariable {Name = name, Value = value};
        }
        public static Operand GetRandomInherited() {
            var i = Aids.GetRandom.Int32()%6;
            switch (i) {
                case 1:
                    return BooleanVariable.Random();
                case 2:
                    return IntegerVariable.Random();
                case 3:
                    return DoubleVariable.Random();
                case 4:
                    return DateTimeVariable.Random();
                case 5:
                    return DecimalVariable.Random();
                default:
                    return StringVariable.Random();
            }
        }
    }
}

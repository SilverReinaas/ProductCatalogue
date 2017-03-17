using System;
namespace Open.Archetypes.RuleClasses {
    public class DateTimeVariable : Variable<DateTime> {
        public new static DateTimeVariable Empty { get; } = new DateTimeVariable();
        public override bool IsEmpty() { return Equals(Empty); }
        //public override DateTime Convert(string s) {
        //    return Safe.Run(() => DateTime.Parse(s), DateTime.MaxValue);
        //}
        public new static DateTimeVariable Random() {
            var x = new DateTimeVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valueField = Aids.GetRandom.DateTime();
        }
    }
}

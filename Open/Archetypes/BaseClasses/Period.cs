using System;
namespace Open.Archetypes.BaseClasses {
    public class Period : Interval<DateTime> {
        public static DateTime MinValue { get; } =
            DateTime.MinValue.ToUniversalTime();
        public static DateTime MaxValue { get; } =
            DateTime.MaxValue.ToUniversalTime();
        public Period() {
            fromField = MinValue;
            toField = MaxValue;
        }
        public static Period Empty { get; } = new Period();
        public new bool IsEmpty() { return Equals(Empty); }
        public static bool IsValid(DateTime fromDate, DateTime toDate) {
            var now = DateTime.Now;
            var period = new Period {From = fromDate, To = toDate};
            var r = period.IsValid(now);
            return r;
        }
        public bool IsValid(DateTime dateTime) {
            if (dateTime > To) return false;
            return dateTime >= From;
        }
        public static Period Random() {
            var d = new Period();
            d.SetRandomValues();
            return d;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            fromField = Aids.GetRandom.DateTime();
            toField = Aids.GetRandom.DateTime(fromField);
        }
    }
}

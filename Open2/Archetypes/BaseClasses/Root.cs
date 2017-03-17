namespace Open.Archetypes.BaseClasses {
    public class Root {
        public virtual bool IsEmpty() { return false; }
        public static bool IsEmpty(string s) { return string.IsNullOrEmpty(s); }
        public bool IsEqual(object x) { return IsEqual(this, x); }
        public static bool IsEqual(object x, object y) {
            if (IsNull(x) && IsNull(y)) return false;
            return !IsNull(y) && y.Equals(x);
        }
        public static bool IsNull(object o) { return ReferenceEquals(null, o); }
        public static bool IsSpaces(string s) {
            return IsEmpty(s) || IsEmpty(s.Trim());
        }
    }
}

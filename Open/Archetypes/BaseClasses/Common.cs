namespace Open.Archetypes.BaseClasses {
    public class Common : Serializable {
        public bool IsSameContent(object x) { return IsSameContent(this, x); }
        public static bool IsSameContent(object x, object y) {
            if (IsNull(x) && IsNull(y)) return false;
            if (!IsNull(y) && string.IsNullOrEmpty(y.ToString())) return false;
            return y.ToString().Equals(x.ToString());
        }
        public override string ToString() { return ToJson(this); }
        public static T Parse<T>(string s) where T : Serializable, new() {
            return FromJson<T>(s);
        }
        public static bool TryParse<T>(string s, out T obj) where T : Serializable, new() {
            obj = FromJson<T>(s);
            return obj.ToString() == s;
        }
    }
}

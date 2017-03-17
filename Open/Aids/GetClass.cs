using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Open.Aids {
    public class GetClass {
        private const string g = "get_";
        private const string s = "set_";
        private const string a = "add_";
        private const string r = "remove_";
        private const string c = ".ctor";
        private const string v = "value__";
        private const string t = "+TestClass";
        public static string Namespace(Type type) {
            return Utils.IsNull(type) ? string.Empty : type.Namespace;
        }
        public static List<MemberInfo> Members(Type type, BindingFlags f = GetPublic.All, bool clean = true ) {
            var l = Safe.Run(() => type.GetMembers(f).ToList(), new List<MemberInfo>());
            if (clean) RemoveSurrogates(l);
            return l;
        }
        internal static void RemoveSurrogates(IList<MemberInfo> l) {
            for (var i = l.Count; i > 0; i--) {
                var m = l[i - 1];
                if (!IsSurrogate(m)) continue;
                l.RemoveAt(i - 1);
            }
        }
        private static bool IsSurrogate(MemberInfo m) {
            var n = m.Name;
            if (string.IsNullOrEmpty(n)) return false;
            if (n.Contains(g)) return true;
            if (n.Contains(s)) return true;
            if (n.Contains(a)) return true;
            if (n.Contains(r)) return true;
            if (n.Contains(v)) return true;
            return n.Contains(t) || n.Contains(c);
        }
        public static List<PropertyInfo> Properties(Type type, BindingFlags f = GetPublic.All) {
            return Safe.Run(() => type.GetProperties(f).ToList(), new List<PropertyInfo>());
        }
    }
}

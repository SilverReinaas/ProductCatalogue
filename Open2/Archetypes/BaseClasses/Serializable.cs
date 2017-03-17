using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public class Serializable: Root {
        public static T FromJson<T>(string s) where T : Serializable, new() {
            return Json.From<T>(s);
        }
        public static T FromXml<T>(string s) where T : Serializable, new() {
            return Xml.From<T>(s);
        }
        public static string ToJson<T>(T o) { return Json.To(o); }
        public static string ToXml<T>(T o) { return Xml.To(o); }
    }
}
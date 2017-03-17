using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace Open.Aids {
    public class Xml {
        public static string To<T>(T o) {
            return Safe.Run(() => {
                var x = new XmlSerializer(o.GetType());
                var b = new StringWriter();
                var s = new XmlWriterSettings();
                var w = XmlWriter.Create(b, s);
                x.Serialize(b, o);
                w.Flush();
                var r = b.ToString();
                return r;
            }, string.Empty);
        }
        public static T From<T>(string s) where T : new() {
            return Safe.Run(() => {
                if (string.IsNullOrEmpty(s)) return default(T);
                s = s.Trim();
                var c = new XmlSerializer(typeof(T));
                var b = new StringReader(s);
                var r = XmlReader.Create(b);
                var o = (T) c.Deserialize(r);
                return o;
            }, default(T));
        }
    }
}

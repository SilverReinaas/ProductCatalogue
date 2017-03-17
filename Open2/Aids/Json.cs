using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Open.Aids {
    public class Json {
        private static DataContractJsonSerializerSettings Settings { get; } =
            new DataContractJsonSerializerSettings {DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssK")};
        public static string To<T>(T t) {
            return Safe.Run(() => {
                var j = new DataContractJsonSerializer(t.GetType(), Settings);
                var m = new MemoryStream();
                j.WriteObject(m, t);
                var s = Encoding.UTF8.GetString(m.ToArray());
                m.Close();
                return s;
            }, string.Empty);
        }
        public static T From<T>(string s) where T : new() {
            return Safe.Run(() => {
                var j = new DataContractJsonSerializer(typeof(T), Settings);
                var m = new MemoryStream(Encoding.UTF8.GetBytes(s));
                var o = (T) j.ReadObject(m);
                return o;
            }, new T());
        }
    }
}

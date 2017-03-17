
namespace Open.Aids {
    public class GetString {
        public static string Head(string text, char separator) {
            return Safe.Run(() => {
                var i = text.IndexOf(separator);
                return i < 0 ? text : text.Substring(0, i);
            }, string.Empty);
        }
        public static string Tail(string text, char separator) {
            return Safe.Run(() => {
                var i = text.IndexOf(separator);
                return i < 0 ? text : text.Substring(i+1);
            }, string.Empty);
        }
    }
}

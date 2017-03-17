using System;
using System.Diagnostics;

namespace Open.Aids {
    public class Log {
        public static string Source => GetSolution.Name;
        public static string Message(Exception e) {
            const string f =
                "Source: {0}\nHResult: {1}\nMessage: {2}\nStackTrace: {3}";
            return Utils.IsNull(e)
                ? string.Empty
                : string.Format(f, e.Source, e.HResult, e.Message, e.StackTrace);
        }
        public static void Exception(Exception e) {
            if (Utils.IsNull(e)) return;
            var m = Message(e);
            Error(m);
        }
        public static void Error(string message) {
            EventLog.WriteEntry(Source, message, EventLogEntryType.Error);
        }
        public static EventLogEntryCollection Entries => Instance.Entries;
        public static void Clear() { Instance.Clear(); }
        public static EventLog Instance => new EventLog {Source = Source};
    }
}

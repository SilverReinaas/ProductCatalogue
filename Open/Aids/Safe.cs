using System;
namespace Open.Aids {
    public class Safe {
        private static readonly object key = new object();
        public static T Run<T>(Func<T> function, T valueOnExeption) {
            lock (key)
                try {
                    return function();
                } catch (Exception e) {
                    Log.Exception(e);
                    return valueOnExeption;
                }
        }
        public static void Run(Action action) {
            lock (key)
                try {
                    action();
                } catch (Exception e) {
                    Log.Exception(e);
                }
        }
    }
}

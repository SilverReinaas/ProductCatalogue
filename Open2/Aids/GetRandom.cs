using System;
using System.Collections.Generic;
using System.Text;
namespace Open.Aids {
    public class GetRandom {
        private static readonly Random rnd = new Random(123456);
        public static bool Bool() { return rnd.Next() % 2 == 0; }
        public static char Char(char min = char.MinValue, char max = char.MaxValue) {
            var i = Int32(min, max);
            return (char) i;
        }
        public static byte Count(byte min = 5, byte max = 10) {
            return UInt8(min, max);
        }
        public static DateTime DateTime(DateTime? min = null,
            DateTime? max = null) {
            var f = min ?? new DateTime(1900, 1, 1);
            var t = max ?? new DateTime(2100, 1, 1);
            if (t <= f) return f;
            var r = (t - f).Ticks;
            var x = new TimeSpan((long) (rnd.NextDouble() * r));
            return f + x;
        }
        public static decimal Decimal(decimal min = decimal.MinValue,
            decimal max = decimal.MaxValue) {
            var d = Double(Convert.ToDouble(min), Convert.ToDouble(max));
            return Convert.ToDecimal(d);
        }
        public static double Double(double min = double.MinValue,
            double max = double.MaxValue) {
            if (max <= min) return min;
            return min + rnd.NextDouble() * (max - min);
        }
        public static T Enum<T>() {
            return Safe.Run(() => {
                var c = GetEnum.Count<T>();
                if (c == 0) return default(T);
                var i = Int32(0, c - 1);
                return GetEnum.Value<T>(i);
            }, default(T));
        }
        public static float Float(float min = float.MinValue,
            float max = float.MaxValue) {
            var f = Double(min, max);
            return Convert.ToSingle(f);
        }
        public static sbyte Int8(sbyte min = -128, sbyte max = 127) {
            var i = Int32(min, max);
            return Convert.ToSByte(i);
        }
        public static short Int16(short min = -32768, short max = 32767) {
            var i = Int32(min, max);
            return Convert.ToInt16(i);
        }
        public static int Int32(int min = int.MinValue, int max = int.MaxValue) {
            return max < min ? min : rnd.Next(min, max);
        }
        public static long Int64(long min = long.MinValue,
            long max = long.MaxValue) {
            if (max <= min) return min;
            var range = (ulong) (max - min);
            ulong r;
            do {
                var buf = new byte[8];
                rnd.NextBytes(buf);
                r = (ulong) BitConverter.ToInt64(buf, 0);
            } while (r > ulong.MaxValue - (ulong.MaxValue % range + 1) % range);
            return (long) (r % range) + min;
        }
        public static string String(int min = 10, int max = 20) {
            var b = new StringBuilder();
            var size = Int32(min, max);
            for (var i = 0; i < size; i++) b.Append(Char('A', 'z'));
            return b.ToString();
        }
        public static IEnumerable<string> Strings() {
            var c = Count();
            var l = new List<string>();
            for (var i = 0; i < c; i++)
                l.Add(String());
            return l;
        }
        public static byte UInt8(byte min = 0, byte max = 255) {
            var i = Int32(min, max);
            return Convert.ToByte(i);
        }
        public static ushort UInt16(ushort min = 0, ushort max = 65535) {
            var i = Int32(min, max);
            return Convert.ToUInt16(i);
        }
        public static uint UInt32(uint min = 0, uint max = uint.MaxValue) {
            if (max < min) return min;
            var x = Convert.ToDouble(max) - Convert.ToDouble(min);
            x *= rnd.NextDouble();
            return min + Convert.ToUInt32(x);
        }
        public static ulong UInt64(ulong min = 0, ulong max = ulong.MaxValue) {
            if (max <= min) return min;
            var x = Convert.ToDouble(max) - Convert.ToDouble(min);
            x *= rnd.NextDouble();
            return min + Convert.ToUInt64(x);
        }
    }
}

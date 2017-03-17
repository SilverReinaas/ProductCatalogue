using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
namespace Open.Tests.Aids {
    [TestClass] public class GetRandomTests : ClassTests<GetRandom> {
        [TestMethod] public void BoolTest() {
            IsNotEqualTest(GetRandom.Bool);
        }
        [TestMethod] public void CharTest() {
            var x = GetRandom.Char(GetRandom.Char());
            var y = GetRandom.Char(max: x);
            IsNotEqualTest(() => GetRandom.Char());
            IsEqualTest(() => GetRandom.Char(x, x));
            IsEqualTest(x, () => GetRandom.Char(x, y));
        }
        [TestMethod] public void CountTest() {
            var x = GetRandom.Count(GetRandom.Count());
            var y = GetRandom.Count(max: x);
            IsNotEqualTest(() => GetRandom.Count());
            IsEqualTest(() => GetRandom.Count(x, x));
            IsEqualTest(x, () => GetRandom.Count(x, y));
        }
        [TestMethod] public void DateTimeTest() {
            var x = GetRandom.DateTime(GetRandom.DateTime());
            var y = GetRandom.DateTime(max: x);
            IsNotEqualTest(() => GetRandom.DateTime());
            IsEqualTest(() => GetRandom.DateTime(x, x));
            IsEqualTest(x, () => GetRandom.DateTime(x, y));
        }
        [TestMethod] public void DecimalTest() {
            var x = GetRandom.Decimal(GetRandom.Decimal());
            var y = GetRandom.Decimal(max: x);
            IsNotEqualTest(() => GetRandom.Decimal());
            IsEqualTest(() => GetRandom.Decimal(x, x));
            IsEqualTest(x, () => GetRandom.Decimal(x, y));
        }
        [TestMethod] public void DoubleTest() {
            var x = GetRandom.Double(GetRandom.Double());
            var y = GetRandom.Double(max: x);
            IsNotEqualTest(() => GetRandom.Double());
            IsEqualTest(() => GetRandom.Double(x, x));
            IsEqualTest(x, () => GetRandom.Double(x, y));
        }
        [TestMethod] public void EnumTest() {
            IsNotEqualTest(GetRandom.Enum<IsoGender>);
        }
        [TestMethod] public void FloatTest() {
            var x = GetRandom.Float(GetRandom.Float());
            var y = GetRandom.Float(max: x);
            IsNotEqualTest(() => GetRandom.Float());
            IsEqualTest(() => GetRandom.Float(x, x));
            IsEqualTest(x, () => GetRandom.Float(x, y));
        }
        [TestMethod] public void Int8Test() {
            var x = GetRandom.Int8(GetRandom.Int8());
            var y = GetRandom.Int8(max:x);
            IsNotEqualTest(() => GetRandom.Int8());
            IsEqualTest(() => GetRandom.Int8(x, x));
            IsEqualTest(x, () => GetRandom.Int8(x, y));
        }
        [TestMethod] public void Int16Test() {
            var x = GetRandom.Int16(GetRandom.Int16());
            var y = GetRandom.Int16(max: x);
            IsNotEqualTest(() => GetRandom.Int16());
            IsEqualTest(() => GetRandom.Int16(x, x));
            IsEqualTest(x, () => GetRandom.Int16(x, y));
        }
        [TestMethod] public void Int32Test() {
            var x = GetRandom.Int32(GetRandom.Int32());
            var y = GetRandom.Int32(max: x);
            IsNotEqualTest(() => GetRandom.Int32());
            IsEqualTest(() => GetRandom.Int32(x, x));
            IsEqualTest(x, () => GetRandom.Int32(x, y));
        }
        [TestMethod] public void Int64Test() {
            var x = GetRandom.Int64(GetRandom.Int64());
            var y = GetRandom.Int64(max: x);
            IsNotEqualTest(() => GetRandom.Int64());
            IsEqualTest(() => GetRandom.Int64(x, x));
            IsEqualTest(x, () => GetRandom.Int64(x, y));
        }
        [TestMethod] public void StringTest() {
            IsNotEqualTest(()=>GetRandom.String());
        }
        [TestMethod] public void StringsTest() {
            IsNotEqualTest(GetRandom.Strings);
        }
        [TestMethod] public void UInt8Test() {
            var x = GetRandom.UInt8(GetRandom.UInt8());
            var y = GetRandom.UInt8(max: x);
            IsNotEqualTest(() => GetRandom.UInt8());
            IsEqualTest(() => GetRandom.UInt8(x, x));
            IsEqualTest(x, () => GetRandom.UInt8(x, y));
        }
        [TestMethod] public void UInt16Test() {
            var x = GetRandom.UInt16(GetRandom.UInt16());
            var y = GetRandom.UInt16(max: x);
            IsNotEqualTest(() => GetRandom.UInt16());
            IsEqualTest(() => GetRandom.UInt16(x, x));
            IsEqualTest(x, () => GetRandom.UInt16(x, y));
        }
        [TestMethod] public void UInt32Test() {
            var x = GetRandom.UInt32(GetRandom.UInt32());
            var y = GetRandom.UInt32(max: x);
            IsNotEqualTest(() => GetRandom.UInt32());
            IsEqualTest(() => GetRandom.UInt32(x, x));
            IsEqualTest(x, () => GetRandom.UInt32(x, y));
        }
        [TestMethod] public void UInt64Test() {
            var x = GetRandom.UInt64(GetRandom.UInt64());
            var y = GetRandom.UInt64(max: x);
            IsNotEqualTest(() => GetRandom.UInt64());
            IsEqualTest(() => GetRandom.UInt64(x, x));
            IsEqualTest(x, () => GetRandom.UInt64(x, y));
        }
    }
}

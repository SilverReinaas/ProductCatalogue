using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests {
    [TestClass] public class IsAidsTested : IsTestedBase {
        [TestMethod] public void Aids() { GetMembers(Namespace("Aids")); }
    }
}


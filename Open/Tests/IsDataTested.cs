using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests {
    [TestClass] public class IsDataTested : IsTestedBase {
        [TestMethod] public void Data() { GetMembers(Namespace("Data")); }
    }
}


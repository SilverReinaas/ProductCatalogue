using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests {
    [TestClass] public class IsLogicTested : IsTestedBase {
        [TestMethod] public void Logic() { GetMembers(Namespace("Logic")); }
    }
}

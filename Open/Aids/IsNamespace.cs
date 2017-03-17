using System.Linq;
namespace Open.Aids {
    public class IsNamespace {
        public static bool Running(string name) {
            if (string.IsNullOrEmpty(name)) return false;
            return
                Safe.Run(
                    () =>
                        GetSolution.Assemblies.Any(
                            a => a.FullName.StartsWith(name)), false);
        }
    }
}

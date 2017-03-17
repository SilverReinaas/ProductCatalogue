using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.RoleClasses {
    public class RoleTypes : Archetypes<RoleType> {
        public static RoleTypes Instance { get; } = new RoleTypes();
        public static RoleType Find(string uniqueId) { return Instance.Find(x => x.IsThisUniqueId(uniqueId)); }
        public static RoleTypes Random()
        {
            var r = new RoleTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(RoleType.Random());
            return r;
        }
    }
}

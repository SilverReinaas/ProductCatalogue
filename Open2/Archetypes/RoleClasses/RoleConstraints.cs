using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.RoleClasses {
    public class RoleConstraints : Archetypes<RoleConstraint> {
        public static RoleConstraints Instance { get; } = new RoleConstraints();
        public static RoleConstraints GetTypeConstraints(string uniqueId) {
            var c = new RoleConstraints();
            var l = Instance.FindAll(x => x.RoleTypeId == uniqueId);
            c.AddRange(l);
            return c;
        }
        public static RoleConstraint Find(string uniqueId) {
            return Instance.Find(x => x.UniqueId == uniqueId);
        }
        public static RoleConstraints Random() { 
                var r = new RoleConstraints();
                var c = GetRandom.Count();
                for (var i = 0; i < c; i++) r.Add(RoleConstraint.Random());
                return r;
        }
    }
}

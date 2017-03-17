using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.RoleClasses
{
    public class Roles: Archetypes<Role>
    {
        public static Roles Instance { get; } = new Roles();

        public static Roles GetPerformerRoles(string uniqueId) {
            var r = new Roles();
            var l = Instance.FindAll(x => x.IsPerformerId(uniqueId));
            r.AddRange(l);
            return r;
        }
        public static Role Find(string uniqueId) {
            return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        }
        public static Roles Random() {
            var r = new Roles();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(Role.Random());
            return r;
        }
    }
}

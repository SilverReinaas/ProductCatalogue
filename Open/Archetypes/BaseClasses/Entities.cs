using Open.Aids;
namespace Open.Archetypes.BaseClasses
{
    public class Entities: Archetypes<Entity>
    {
        public static Entities Instance { get; } = new Entities();
        public static Entity Find(string uniqueId) {
            return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        }
        public static Entities Random() {
            var e = new Entities();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) 
                e.Add(Entity.Random());
            return e;
        }
    }
}

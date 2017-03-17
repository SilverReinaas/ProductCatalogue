
using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public class EntityTypes : Archetypes<EntityType> {
        public static EntityTypes Instance { get; } = new EntityTypes();

        public static EntityType Find(string uniqueId) { return Instance.Find(x => x.IsThisUniqueId(uniqueId)); }
        public static EntityTypes Random() {
            var e = new EntityTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                e.Add(EntityType.Random());
            return e;
        }
    }
}


using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.RelationshipClasses
{
    public class RelationshipTypes: Archetypes<RelationshipType>
    {
        public static RelationshipTypes Instance { get; } = new RelationshipTypes();
        public static RelationshipTypes Random() {
            var r = new RelationshipTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(RelationshipType.Random());
            return r;
        }
        public static RelationshipType Find(string id) {
            return Instance.Find(x => x.UniqueId == id);
        }
    }
}

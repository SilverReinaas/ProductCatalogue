using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.RelationshipClasses
{
    public class RelationshipConstraints: Archetypes<RelationshipConstraint>
    {
        public static RelationshipConstraints Instance { get; } = new RelationshipConstraints();
        public static RelationshipConstraints Random() {
            var r = new RelationshipConstraints();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(RelationshipConstraint.Random());
            return r;
        }
        public static RelationshipConstraints GetTypeConstraints(string uniqueId) {
            var r = new RelationshipConstraints();
            var l = Instance.FindAll(x => x.RelationshipTypeId == uniqueId);
            r.AddRange(l);
            return r;
        }
    }
}

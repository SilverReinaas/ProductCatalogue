using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.RelationshipClasses {
    public class Relationships : Archetypes<Relationship> {
        public static Relationships Instance { get; } = new Relationships();
        public static Relationships GetRoleRelationships(string id) {
            var r = new Relationships();
            var l = Instance.FindAll(x => x.IsInRole(id));
            r.AddRange(l);
            return r;
        }
        public static Relationships GetProviderRelationships(string id) {
            var r = new Relationships();
            var l = Instance.FindAll(x => x.ProviderId == id);
            r.AddRange(l);
            return r;
        }
        public static Relationships GetConsumerRelationships(string id) {
            var r = new Relationships();
            var l = Instance.FindAll(x => x.ConsumerId == id);
            r.AddRange(l);
            return r;
        }
        public static Relationships Random() {
            var r = new Relationships();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(Relationship.Random());
            return r;
        }
    }
}

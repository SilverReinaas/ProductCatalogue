using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.RelationshipClasses
{
    public class RelationshipType: BaseType<RelationshipType> {
        public override RelationshipType Type => RelationshipTypes.Find(TypeId);
        public RelationshipConstraints Constraints => RelationshipConstraints.GetTypeConstraints(UniqueId);
        public static RelationshipType Random() {
            var r = new RelationshipType();
            r.SetRandomValues();
            return r;
        }
    }
}

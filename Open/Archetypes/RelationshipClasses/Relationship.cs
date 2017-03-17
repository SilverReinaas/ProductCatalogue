using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RoleClasses;
namespace Open.Archetypes.RelationshipClasses {
    public class Relationship : BaseEntity<RelationshipType> {
        private string providerId;
        private string consumerId;
        public string ProviderId {
            get { return SetDefault(ref providerId); }
            set { SetValue(ref providerId, value);}
        }
        public string ConsumerId {
            get { return SetDefault(ref consumerId); }
            set { SetValue(ref consumerId, value); }
        }
        public override RelationshipType Type => RelationshipTypes.Find(TypeId);
        public Role Provider => Roles.Find(ProviderId); 
        public Role Consumer => Roles.Find(ConsumerId);
        public bool IsInRole(string id) {
            if (IsSpaces(id)) return false;
            if (ConsumerId == id) return true;
            return ProviderId == id;
        }
        public static Relationship Random() {
            var r = new Relationship();
            r.SetRandomValues();
            return r;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            providerId = GetRandom.String();
            consumerId = GetRandom.String();
        }
    }
}

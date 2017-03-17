using Open.Aids;
using Open.Archetypes.RoleClasses;
using Open.Archetypes.RuleClasses;
namespace Open.Archetypes.RelationshipClasses
{
    public class RelationshipConstraint: Rule
    {
        private string validConsumerRoleTypeId;
        private string validProviderRoleTypeId;
        private string relationshipTypeId;
        public string ValidConsumerRoleTypeId {
            get { return SetDefault(ref validConsumerRoleTypeId); }
            set { SetValue(ref validConsumerRoleTypeId, value);}
        }
        public string ValidProviderRoleTypeId
        {
            get { return SetDefault(ref validProviderRoleTypeId); }
            set { SetValue(ref validProviderRoleTypeId, value); }
        }
        public RoleType ValidConsumerRoleType => RoleTypes.Find(ValidConsumerRoleTypeId);
        public RoleType ValidProviderRoleType => RoleTypes.Find(ValidProviderRoleTypeId);
        public string RelationshipTypeId {
            get { return SetDefault(ref relationshipTypeId); }
            set { SetValue(ref relationshipTypeId, value);}
        }
        public RelationshipType RelationshipType => RelationshipTypes.Find(RelationshipTypeId);
        public static RelationshipConstraint Random() {
            var r = new RelationshipConstraint();
            r.SetRandomValues();
            return r;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            validProviderRoleTypeId = GetRandom.String();
            validConsumerRoleTypeId = GetRandom.String();
        }
    }
}

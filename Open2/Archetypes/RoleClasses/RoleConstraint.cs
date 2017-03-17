using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.RuleClasses;
namespace Open.Archetypes.RoleClasses {
    public class RoleConstraint : Rule {
        private string roleTypeId;
        private string validPerformerTypeId;
        public string ValidPerformerTypeId
        {
            get { return SetDefault(ref validPerformerTypeId); }
            set { SetValue(ref validPerformerTypeId, value); }
        }
        public string RoleTypeId {
            get { return SetDefault(ref roleTypeId); }
            set { SetValue(ref roleTypeId, value); }
        }
        public virtual EntityType ValidPerformerType
            => EntityTypes.Find(ValidPerformerTypeId);
        public virtual RoleType RoleType
            => RoleTypes.Find(RoleTypeId);
        public static RoleConstraint Random() {
            var c = new RoleConstraint();
            c.SetRandomValues();
            return c;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            roleTypeId = GetRandom.String();
            validPerformerTypeId = GetRandom.String();
        }
    }
}

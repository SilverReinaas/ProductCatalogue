using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.RoleClasses {
    public class Role : BaseEntity<RoleType> {
        private string performerId;
        public string PerformerId {
            get { return SetDefault(ref performerId); }
            set { SetValue(ref performerId, value); }
        }
        public virtual Entity Performer => Entities.Find(PerformerId);
        public bool IsPerformerId(string id) {
            if (IsSpaces(id)) return false;
            return PerformerId == id;
        }
        public static Role Random() {
            var e = new Role();
            e.SetRandomValues();
            return e;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            performerId = GetRandom.String();
        }
        public override RoleType Type => RoleTypes.Find(TypeId);
    }
}


using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public abstract class UniqueEntity : AttributedEntity {
        private string uniqueId;
        public string UniqueId {
            get { return SetDefault(ref uniqueId); }
            set { SetValue(ref uniqueId, value); }
        }
        public override Attributes GetAttributes() {
            var a = new Attributes();
            var l = Attributes.Instance.FindAll(o => o.EntityId == UniqueId);
            a.AddRange(l);
            return a;
        }
        public bool IsThisUniqueId(string id) {
            if (IsSpaces(id)) return false;
            return UniqueId == id;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            uniqueId = GetRandom.String();
        }
    }
}

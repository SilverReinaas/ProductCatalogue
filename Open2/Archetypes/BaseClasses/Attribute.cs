using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public class Attribute : Archetype {
        private Archetypes<string> tags;
        private string entityId;
        public string EntityId {
            get { return SetDefault(ref entityId); }
            set { SetValue(ref entityId, value); }
        }
        public static Attribute Random() {
            var a = new Attribute();
            a.SetRandomValues();
            return a;
        }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            entityId = GetRandom.String();
        }
        public Archetypes<string> Tags {
            get { return SetDefault(ref tags); }
            set { SetValue(ref tags, value); }
        }
    }
}

using Open.Aids;
namespace Open.Archetypes.BaseClasses {
    public abstract class BaseType<T> : UniqueEntity where T:BaseType<T> {
        private string typeId;
        public string TypeId {
            get { return SetDefault(ref typeId); }
            set { SetValue(ref typeId, value); }
        }
        public abstract T Type { get; }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            typeId = GetRandom.String();
        }
    }
}

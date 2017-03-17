namespace Open.Archetypes.BaseClasses {
    public abstract class TemporalEntity : Archetype {
        private Period valid;
        public Period Valid { get { return SetDefault(ref valid); } set { SetValue(ref valid, value); } }
        protected override void SetRandomValues() {
            base.SetRandomValues();
            valid = Period.Random();
        }
    }
}

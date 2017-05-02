using Open.Aids;
using Open.Archetypes.OrderClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.BaseClasses {
    public abstract class BaseType<T> : UniqueEntity where T:BaseType<T> {
        private string typeId;
        [Key, Column(Order = 6)]
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

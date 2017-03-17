namespace Open.Archetypes.BaseClasses
{
    public class EntityType : BaseType<EntityType> {
        public override EntityType Type => EntityTypes.Find(TypeId);
        public static EntityType Random() {
            var e = new EntityType();
            e.SetRandomValues();
            return e;
        }
    }
}

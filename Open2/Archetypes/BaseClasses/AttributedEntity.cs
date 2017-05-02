using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.BaseClasses
{
    public abstract class AttributedEntity: TemporalEntity {
        public abstract Attributes Attributes { get; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Archetypes.BaseClasses {
    public class Attributes : Archetypes<Attribute> {
        public static Attributes Instance { get; } = new Attributes();

    }
}

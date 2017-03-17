
namespace Open.Archetypes.ProductClasses
{
    public class ExecutingService: Service
    {
        public bool Complete() { return false; }
        public bool Cancel() { return false; }
    }
}

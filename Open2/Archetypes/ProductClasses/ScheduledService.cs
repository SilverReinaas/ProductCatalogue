namespace Open.Archetypes.ProductClasses {
    public class ScheduledService : Service {
        public bool Reschedule() { return false; }
        public bool Execute() { return false; }
        public bool Cancel() { return false; }
    }
}

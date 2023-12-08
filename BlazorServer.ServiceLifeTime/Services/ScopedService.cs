namespace BlazorServer.ServiceLifeTime.Services
{
    public class ScopedService
    {
        public Guid Guid { get; set; }

        public ScopedService()
          => Guid = Guid.NewGuid();
    }
    public class SingletonService
    {
        public Guid Guid { get; set; }

        public SingletonService()
          => Guid = Guid.NewGuid();
    }
    public class TransientService
    {
        public Guid Guid { get; set; }

        public TransientService()
          => Guid = Guid.NewGuid();
    }
}

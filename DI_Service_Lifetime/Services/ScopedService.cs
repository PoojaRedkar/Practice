namespace DI_Service_Lifetime.Services
{
    public class ScopedService : _IScopedService
    {
        private readonly Guid _guid;

        public ScopedService()
        {
                _guid = Guid.NewGuid();
        }
        public string getGuid()
        {
            return _guid.ToString();
        }
    }
}

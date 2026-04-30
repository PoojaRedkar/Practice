namespace DI_Service_Lifetime.Services
{
    public class SingletonService : _ISingletonService
    {
        private readonly Guid _guid; 
        public SingletonService() 
        {
            _guid = Guid.NewGuid();
        }

        public string getGuid()
        {
            return _guid.ToString();
        }
    }
}

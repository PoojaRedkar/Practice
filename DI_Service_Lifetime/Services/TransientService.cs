namespace DI_Service_Lifetime.Services
{
    public class TransientService : _ITransientService
    {
        private readonly Guid _guid;

        public TransientService()
        {
              _guid = Guid.NewGuid();
        }
        public string getGuid()
        {
            return _guid.ToString();
        }
    }
}

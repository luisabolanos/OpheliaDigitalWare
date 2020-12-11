using System.Collections.Generic;

namespace OpheliaDigitalWare.Api.Client
{
    public class ClientService : IClientServices
    {
        private IClientRepository repository;

        public ClientService(IClientRepository repository)
        {
            this.repository = repository;
        }

        public List<Client> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}

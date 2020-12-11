using OpheliaDigitalWare.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace OpheliaDigitalWare.Api.Client
{
    public class ClientRepository : IClientRepository
    {
        private AppDbContext context;

        public ClientRepository(AppDbContext context)
        {
            this.context = context;
        }

        public List<Client> GetAll()
        {
            return this.context.Client.ToList();
        }
    }
}

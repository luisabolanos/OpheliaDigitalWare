using OpheliaDigitalWare.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace OpheliaDigitalWare.Api.Client
{
    public class ClientAlternativeRepository : IClientRepository
    {
        private AppDbContext context;

        public ClientAlternativeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public List<Client> GetAll()
        {
            return new List<Client>();
        }
    }
}

using System.Collections.Generic;

namespace OpheliaDigitalWare.Api.Client
{
    public interface IClientRepository
    {
        List<Client> GetAll();
    }
}

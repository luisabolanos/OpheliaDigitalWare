using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpheliaDigitalWare.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpheliaDigitalWare.Api.Client
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> logger;
        private IClientServices service;

        public ClientController(ILogger<ClientController> logger, IClientServices service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            this.logger.LogInformation("[GET] init get");

            return this.service.GetAll();
        }
    }
}

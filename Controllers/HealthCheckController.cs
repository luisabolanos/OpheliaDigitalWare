using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace OpheliaDigitalWare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> logger;
        private IConfiguration configuration;

        public HealthCheckController(ILogger<HealthCheckController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }

        [HttpGet]
        public OkObjectResult Get()
        {
            this.logger.LogInformation("[GET] init get");

            String version =  this.configuration.GetValue<String>("Version");

            return Ok(new { version = version });
        }

        
    }
}

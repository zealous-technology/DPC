using DPC.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DPC.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {

        private readonly IGreetingService _greetingService;
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(IGreetingService greetingService,
            ILogger<GreetingController> logger)
        {
            _greetingService = greetingService;
            _logger = logger;
        }

        [HttpGet]
        public string Get() => _greetingService.SayHelloWorld();

        // trigger build
    }
}
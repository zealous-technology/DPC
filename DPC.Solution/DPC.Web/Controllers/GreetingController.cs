using DPC.Web.Models;
using DPC.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPC.Web.Controllers
{
    [ApiController]
    [Authorize]
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


        [HttpPost]
        public IActionResult AddGreeting([FromBody] Greeting greeting)
        {
            _logger.LogInformation("Adding greeting with message: {Message}", greeting.Message);

            return Created(string.Empty, new { greeting.Message });

        }
    }
}
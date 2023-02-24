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
        private readonly ICustomSettings _customSettings;
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(IGreetingService greetingService,
            ICustomSettings customSettings,
            ILogger<GreetingController> logger)
        {
            _greetingService = greetingService;
            _customSettings = customSettings;
            _logger = logger;
        }

        [HttpGet("Settings")]
        [AllowAnonymous]
        public string Settings() => _customSettings.ToString();

        [HttpGet("Backdoor")]
        [AllowAnonymous]
        public string Backdoor() => _greetingService.SayHelloWorld();

        [HttpGet()]
        [Authorize(Roles = "Manager")]
        public string Get() => _greetingService.SayHelloWorld();


        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult AddGreeting([FromBody] Greeting greeting)
        {
            _logger.LogInformation("Adding greeting with message: {Message}", greeting.Message);

            return Created(string.Empty, new { greeting.Message });

        }
    }
}
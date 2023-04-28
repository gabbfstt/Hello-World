using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {

        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string ola = "Ola";

            return Content(ola);
        }
    }
}

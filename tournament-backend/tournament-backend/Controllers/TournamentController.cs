using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tournament_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentController : ControllerBase
    {
        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns the text "Nerdneck is awesome!"
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "Nerdneck is awesome!";
        }
    }
}

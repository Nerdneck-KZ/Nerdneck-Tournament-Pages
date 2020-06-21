using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public string Get()
        {
            return "Nerdneck is awesome!";
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NTierExample.Application.Interfaces;

namespace NTierExample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NTierController : ControllerBase
    {

        private readonly ILogger<NTierController> _logger;
        private readonly IBaristaService _baristaService;
        public NTierController(ILogger<NTierController> logger, IBaristaService baristaService)
        {
            _logger = logger;
            _baristaService = baristaService;
        }

        [HttpGet(Name = "{round}")]
        public async Task<IActionResult> Get(int round)
        {
            var barista = await _baristaService.GetBarista(round);
            if (barista == null) return NotFound();

            return Ok(barista);
        }
    }
}
using System.Threading.Tasks;
using CoinMarket.Service.Service.Define;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoinMarket.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AdvertController : BaseController
    {
        private IAdvertService _advertService;

        public AdvertController(IAdvertService advertService)
        {
            _advertService = advertService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAdverts()
        {
            var result = await _advertService.GetAdverts();
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);

        }

    }
}
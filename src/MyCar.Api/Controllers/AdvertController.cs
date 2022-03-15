using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCar.Infrastructure.Request;
using MyCar.Service.Service.Define;

namespace MyCar.Api.Controllers
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
        public async Task<IActionResult> GetAdvertsAsync([FromQuery] GetAllAdvertsRequest request)
        {
            var result = await _advertService.GetAdvertsAsync(request);
            if (result.Data == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdvertByIdAsync([FromRoute] int id)
        {
            var result = await _advertService.GetAdvertByIdAsync(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("{advertId}/visit")] 
        public async Task<IActionResult> AddAdvertVisitAsync([FromRoute] int advertId)
        {
            var result = await _advertService.AddAdvertVisitAsync(advertId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Created("", null);
        }

    }
}
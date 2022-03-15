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
        public async Task<IActionResult> GetAdverts([FromRoute] PaginationRequest request)
        {
            var result = await _advertService.GetAdverts(request);
            if (result?.Data == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdvertById([FromRoute] int id)
        {
            var result = await _advertService.GetAdvertById(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    }
}
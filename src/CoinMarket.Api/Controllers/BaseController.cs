using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoinMarket.Api.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
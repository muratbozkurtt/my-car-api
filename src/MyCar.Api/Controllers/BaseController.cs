using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyCar.Api.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
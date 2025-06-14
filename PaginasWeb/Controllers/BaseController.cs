using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaginasWeb.Models;

namespace PaginasWeb.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        private readonly ILogger<BaseController> _logger;

        public BaseController()
        {
        }
        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginasWeb.Models;

namespace PaginasWeb.Controllers
{
    public class AdministracionController : BaseController
    {

        public AdministracionController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

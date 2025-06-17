using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginasWeb.Controllers;
using PaginasWeb.Models;

namespace PaginasWeb.Administracion.Controllers
{
    public class SitiosController : BaseController
    {

        public SitiosController()
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

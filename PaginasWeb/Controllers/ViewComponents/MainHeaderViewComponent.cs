
using CommonsNuget.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using PaginasWeb.Data;
using PaginasWeb.Models.Administracion;
using System.Drawing;

namespace PaginasWeb.ViewComponents
{
    public class MainHeaderViewComponent : ViewComponent
    {
        public ApplicationDbContext _context;
        public MainHeaderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var userName = this.User.Identity.Name;
            Usuario usuario = _context.Usuario.Where(u => u.UserName == userName).FirstOrDefault();

            ViewBag.UserName = usuario?.UserName; // Esto podrías sacarlo del ClaimsPrincipal  
            ViewBag.UserAvatar = "/img/user.jpg"; // o un avatar por defecto si no hay
            ViewBag.backgroundColor = "#343a40;"; // Color del NavBar
            ViewBag.TextColor = "#ffffff;"; // Color de Texto del NavBar

            MainHeader notificaciones = new MainHeader()
            {
                Cant = "3",
                Notifications = new List<Notificaciones>()
                {
                    new Notificaciones() { IconClass = "fa-solid fa-envelope", Text = "Mensaje Enviado", Time = "3 min", Url = "" },
                    new Notificaciones() { IconClass = "fa-solid fa-file", Text = "Nuevo Reporte", Time = "12 horas", Url = "" },
                    new Notificaciones() { IconClass = "fa-solid fa-envelope", Text = "Mensaje Enviado", Time = "2 días", Url = "" },
                }
            };

            ViewBag.Notificaciones = notificaciones;
            //ViewBag.Notificaciones = null;
            return View();
        }
    }
}

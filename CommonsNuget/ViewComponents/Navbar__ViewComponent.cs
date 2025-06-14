using CommonsNuget.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsNuget.ViewComponents
{
    [ViewComponent]
    public class Navbar__ViewComponent : ViewComponent
    {
        public Navbar__ViewComponent()
        {
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    List<MenuItem> menuItems = GetDefaultMenuItems();
        //    return View(menuItems);
        //}
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
      
}


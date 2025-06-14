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
    public class Sidebar__ViewComponent : ViewComponent
    {
        public Sidebar__ViewComponent()
        {
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    List<MenuItem> menuItems = GetDefaultMenuItems();
        //    return View(menuItems);
        //}
        public IViewComponentResult Invoke()
        {
            List<MenuItem> menuItems = GetDefaultMenuItems();
            return View(menuItems);
        }


        private List<MenuItem> GetDefaultMenuItems()
        {
            var menu = new List<MenuItem>
            {
                new MenuItem
                {
                    Text = "Instalación",
                    Url = "/Home/Instalacion", // URL del Dashboard
                    IconClass = "nav-icon fas fa-microchip"
                },
                new MenuItem
                {
                    Text = "Dashboard",
                    Url = "/Dashboard", // URL del Dashboard
                    IconClass = "nav-icon fas fa-tachometer-alt"
                },
                new MenuItem
                {
                    Text = "Gestión de Contenido",
                    Url = "#", // No tiene URL directa, es un desplegable
                    IconClass = "nav-icon fas fa-edit",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Text = "Artículos",
                            Url = "/Content/Articles",
                            IconClass = "far fa-circle nav-icon" // Iconos para subitems suelen ser diferentes
                        },
                        new MenuItem
                        {
                            Text = "Categorías",
                            Url = "/Content/Categories",
                            IconClass = "far fa-circle nav-icon"
                        },
                        new MenuItem
                        {
                            Text = "Multimedia",
                            Url = "#", // Submenú de segundo nivel con hijos
                            IconClass = "far fa-image nav-icon", // Puedes usar un icono más específico
                            SubItems = new List<MenuItem>
                            {
                                new MenuItem
                                {
                                    Text = "Imágenes",
                                    Url = "/Content/Media/Images",
                                    IconClass = "far fa-dot-circle nav-icon" // Icono para tercer nivel
                                },
                                new MenuItem
                                {
                                    Text = "Videos",
                                    Url = "/Content/Media/Videos",
                                    IconClass = "far fa-dot-circle nav-icon"
                                },
                                new MenuItem
                                {
                                    Text = "Documentos",
                                    Url = "/Content/Media/Documents",
                                    IconClass = "far fa-dot-circle nav-icon"
                                }
                            }
                        }
                    }
                },
                new MenuItem
                {
                    Text = "Configuración",
                    Url = "#",
                    IconClass = "nav-icon fas fa-cogs",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Text = "General",
                            Url = "/Settings/General",
                            IconClass = "far fa-circle nav-icon"
                        },
                        new MenuItem
                        {
                            Text = "Usuarios",
                            Url = "/Settings/Users",
                            IconClass = "far fa-circle nav-icon"
                        },
                        new MenuItem
                        {
                            Text = "Roles y Permisos",
                            Url = "#",
                            IconClass = "far fa-circle nav-icon",
                            SubItems = new List<MenuItem>
                            {
                                new MenuItem
                                {
                                    Text = "Gestionar Roles",
                                    Url = "/Settings/Roles",
                                    IconClass = "far fa-dot-circle nav-icon"
                                },
                                new MenuItem
                                {
                                    Text = "Asignar Permisos",
                                    Url = "/Settings/Permissions",
                                    IconClass = "far fa-dot-circle nav-icon"
                                }
                            }
                        }
                    }
                },
                new MenuItem
                {
                    Text = "Reportes",
                    Url = "/Reports",
                    IconClass = "nav-icon fas fa-chart-pie"
                },
                new MenuItem // Otro ejemplo de un menú de 3 niveles directos
                {
                    Text = "Nivel 1 (A)",
                    Url = "#",
                    IconClass = "nav-icon fas fa-layer-group",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Text = "Nivel 2 (A.1)",
                            Url = "#",
                            IconClass = "far fa-circle nav-icon",
                            SubItems = new List<MenuItem>
                            {
                                 new MenuItem
                                 {
                                    Text = "Nivel 3 (A.1.1)",
                                    Url = "/Nivel/A11",
                                    IconClass = "far fa-dot-circle nav-icon"
                                 },
                                 new MenuItem
                                 {
                                    Text = "Nivel 3 (A.1.2)",
                                    Url = "/Nivel/A12",
                                    IconClass = "far fa-dot-circle nav-icon"
                                 }
                            }
                        },
                        new MenuItem
                        {
                            Text = "Nivel 2 (A.2)",
                            Url = "/Nivel/A2",
                            IconClass = "far fa-circle nav-icon"
                        }
                    }
                }
            };
                return menu;
            }
        }
    }


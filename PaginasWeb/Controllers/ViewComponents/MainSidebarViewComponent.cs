using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Asegúrate de tener este using para List<T>
using System;
using CommonsNuget.Models.Shared;
using CommonsNuget.Helpers; // Asegúrate de tener este using para Tuple (si MenuHelpers lo necesita explícitamente)

namespace PaginasWeb.ViewComponents
{
    public class MainSidebarViewComponent : ViewComponent
    {
        public MainSidebarViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            var sidebars = new List<SidebarMenu>();

            sidebars.Add(MenuHelpers.AddHeader("Menú Principal"));

            var gestion = MenuHelpers.AddTree("Gestión", "fa fa-sitemap");
            var mantenimiento = MenuHelpers.AddTree("Mantenimiento", "fa fa-wrench"); // Icono cambiado para variedad
            var reportes = MenuHelpers.AddTree("Reportes", "fa fa-bar-chart"); // Icono cambiado
            var sistemas = MenuHelpers.AddTree("Sistemas", "fa fa-cogs"); // 'administrador' renombrado a 'sistemas' para claridad, icono cambiado
            

            var dashboard = MenuHelpers.AddModule("Evolución de la Cartera", "/Dashboard", "fa-solid fa-chart-line");
            var dashboard2 = MenuHelpers.AddModule("Ranking de Compañías / Productores", "/Dashboard/Index2", "fa-solid fa-chart-simple");
            var dashboard3 = MenuHelpers.AddModule("Producción de Compañías Estratégicas", "/Dashboard/Index3", "fa-solid fa-building");    


            var instalacion = MenuHelpers.AddModule("Instalación", "/Home/Instalacion", "nav-icon fas fa-microchip");
            var adminlte = MenuHelpers.AddModule("AdminLTE 3", "https://adminlte.io/themes/v3/index.html", "fa-solid fa-a", null, true);

            // --- Gestión (Nivel 1) ----------
            gestion.TreeChild = new List<SidebarMenu>();
            // Nivel 2 para Gestión
            gestion.TreeChild.Add(MenuHelpers.AddModule("Extintores", "/Administracion/Extintores/Index", "far fa-circle text-purple")); // Usando far para iconos huecos
            gestion.TreeChild.Add(MenuHelpers.AddModule("Unidades", "/Administracion/Unidades/Index", "far fa-circle text-purple"));

            // --- Mantenimiento (Nivel 1) ----
            mantenimiento.TreeChild = new List<SidebarMenu>();
            // Nivel 2 para Mantenimiento
            mantenimiento.TreeChild.Add(MenuHelpers.AddModule("Lotes en mantenimiento", "/Mantenimiento/LotesMantenimiento/Index", "far fa-circle text-info"));

            // --- Sistemas (Nivel 1) ----
            sistemas.TreeChild = new List<SidebarMenu>(); // Hijos de Nivel 2 para Sistemas

            // Nivel 2: Usuarios (Link)
            sistemas.TreeChild.Add(MenuHelpers.AddModule("Usuarios", "/Admin/Usuarios/Index", "fa fa-users text-red"));

            // Nivel 2: Funciones (Ahora es un Tree para contener Nivel 3)
            var funcionesNivel2 = MenuHelpers.AddTree("Funciones", "fa fa-shield-alt text-red"); // Icono representativo
            // funcionesNivel2.URLPath = "#"; // No es necesario si tiene hijos, el Razor lo maneja

            // Nivel 3: Hijos de "Funciones"
            funcionesNivel2.TreeChild = new List<SidebarMenu>();
            funcionesNivel2.TreeChild.Add(MenuHelpers.AddModule("Listar Permisos", "/SecurityFunctions/Permissions", "fa fa-list-ul text-yellow"));
            funcionesNivel2.TreeChild.Add(MenuHelpers.AddModule("Asignar Roles", "/SecurityFunctions/AssignRoles", "fa fa-user-check text-yellow"));
            var auditoriaNivel3 = MenuHelpers.AddModule("Auditoría", "/SecurityFunctions/Audit", "fa fa-history text-yellow", null, true); // Ejemplo con OpenInNewTab
            funcionesNivel2.TreeChild.Add(auditoriaNivel3);

            // Añadimos "Funciones" (que ahora tiene hijos de Nivel 3) a "Sistemas"
            sistemas.TreeChild.Add(funcionesNivel2);

            // Nivel 2: Roles (Link)
            sistemas.TreeChild.Add(MenuHelpers.AddModule("Roles Globales", "/SecurityRoles", "fa fa-user-tag text-red"));


            // Añade los ítems de Nivel 1 al menú principal (sidebars)

            sidebars.Add(dashboard);
            sidebars.Add(dashboard2);
            sidebars.Add(dashboard3);
            //sidebars.Add(instalacion);
            //sidebars.Add(adminlte);
            //sidebars.Add(gestion);
            //sidebars.Add(mantenimiento);
            // sidebars.Add(reportes); // Descomenta si quieres añadir la sección Reportes (actualmente sin hijos)
            sidebars.Add(sistemas);
            sidebars.Add(MenuHelpers.AddModule("Salir", "javascript:document.getElementById('logoutForm').submit()", "fa fa-sign-out-alt")); // Icono cambiado

            // --> Comprueba cuántos ítems hay
            System.Diagnostics.Debug.WriteLine($"[SidebarVC] total items root = {sidebars.Count}");

            // Pasamos el nombre de la app al ViewBag
            ViewBag.AppName = "Commons Net 8";
            ViewBag.LogoPath = "/img/logo.png"; // Ajusta la ruta según tu proyecto


            return View(sidebars);           //  <--  pasa el modelo
        }
    }
}
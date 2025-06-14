using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsNuget.Models.Shared
{
    public class MenuItem
    {
        /// <summary>
        /// Identificador único para el ítem del menú, útil para tests o manipulación dinámica si es necesario.
        /// </summary>
        public string Id { get; set; } = "menuitem_" + Guid.NewGuid().ToString("N");

        /// <summary>
        /// El texto que se mostrará para el ítem del menú.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// La URL a la que navegará este ítem del menú.
        /// Puede ser null o "#" si es un ítem padre de un submenú que no navega directamente.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Clase(s) CSS para el ícono del menú (ej. "nav-icon fas fa-tachometer-alt").
        /// </summary>
        public string IconClass { get; set; }

        /// <summary>
        /// Lista de subítems para este ítem del menú, permitiendo menús anidados.
        /// </summary>
        public List<MenuItem> SubItems { get; set; } = new List<MenuItem>();

        /// <summary>
        /// Texto para un badge o etiqueta que se muestra junto al ítem (ej. "Nuevo", "3").
        /// </summary>
        public string BadgeText { get; set; }

        /// <summary>
        /// Clase(s) CSS para el badge (ej. "right badge badge-danger", "right badge badge-info").
        /// </summary>
        public string BadgeClass { get; set; }

        /// <summary>
        /// Indica si este ítem del menú debe considerarse activo (resaltado).
        /// La lógica para establecer esto usualmente compara el Url del ítem con la URL actual.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Para ítems con submenús (IsTreeView = true), indica si el submenú debe mostrarse abierto por defecto o
        /// si se ha abierto debido a que un hijo está activo.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Propiedad de conveniencia para determinar si este ítem tiene subítems y, por lo tanto,
        /// debería ser renderizado como un elemento de tipo "treeview" en AdminLTE.
        /// </summary>
        public bool IsTreeView => SubItems != null && SubItems.Count > 0;
    }
}

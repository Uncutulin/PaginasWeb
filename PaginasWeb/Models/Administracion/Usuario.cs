using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace PaginasWeb.Models.Administracion
{
    public class Usuario : IdentityUser
    {
        public virtual Persona Persona { get; set; }
        public bool Activo { get; set; }
    }
}

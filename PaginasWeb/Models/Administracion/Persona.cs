using System.ComponentModel;

namespace PaginasWeb.Models.Administracion
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DisplayName("Documento")]
        public string NroDocumento { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}

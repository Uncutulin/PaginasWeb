using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsNuget.Models.Shared
{
    public class MainHeader
    {
        public string Cant { get; set; }
        
        public List<Notificaciones> Notifications { get; set; }
    }

    public class Notificaciones
    {
        public string Text { get; set; }
        public string Time { get; set; }
        public string Url { get; set; }
        public string IconClass { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonsNuget.Models.Shared
{
    public class SidebarMenu
    {
        public SidebarMenuType Type { get; set; }
        public bool IsActive { get; set; } = false;
        public string Name { get; set; }
        public string IconClassName { get; set; }
        public string URLPath { get; set; }
        public List<SidebarMenu> TreeChild { get; set; } = new List<SidebarMenu>();
        public Tuple<int, int, int> LinkCounter { get; set; }
        public bool OpenInNewTab { get; set; }
    }

    public enum SidebarMenuType
    {
        Header,
        Link,
        Tree
    }
}

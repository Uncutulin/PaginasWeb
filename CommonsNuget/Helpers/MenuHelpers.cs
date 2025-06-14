﻿using CommonsNuget.Models;
using CommonsNuget.Models.Shared;
using System;

namespace CommonsNuget.Helpers
{
    public static class MenuHelpers
    {
        public static SidebarMenu AddHeader(string name)
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Header,
                Name = name,
            };
        }

        public static SidebarMenu AddTree(string name, string iconClassName = "fa fa-circle-o")
        {
            return new SidebarMenu
            {
                Type = SidebarMenuType.Tree,
                IsActive = false,
                Name = name,
                IconClassName = iconClassName,
                URLPath = "#",
            };
        }

        public static SidebarMenu AddModule(string text, string urlPath, string iconClassName = "fa fa-circle-o", Tuple<int, int, int> counter = null, bool openInNewTab = false)
        {
            if (counter == null)
                counter = Tuple.Create(0, 0, 0);

            var menuItem = new SidebarMenu
            {
                Type = SidebarMenuType.Link,
                Name = text,
                IconClassName = iconClassName,
                URLPath = urlPath,
                LinkCounter = counter,
                OpenInNewTab = openInNewTab
            };

            return menuItem;
        }


    }
}

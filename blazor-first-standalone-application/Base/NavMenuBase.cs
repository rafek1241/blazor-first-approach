using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazorfirststandaloneapplication.shared.Models;
using Microsoft.AspNetCore.Blazor.Components;

namespace blazorfirststandaloneapplication.Base
{
    public class NavMenuBase : BlazorComponent
    {


        public bool CollapseNavMenu { get; private set; } = true;

        public List<MenuLink> MenuLinks { get; private set; }

        protected void ToggleNavMenu()
        {
            CollapseNavMenu = !CollapseNavMenu;
        }

        protected override void OnInit()
        {
            MenuLinks = new List<MenuLink>()
                {
                    new MenuLink()
                    {
                        IconName = "fas fa-cogs",
                        Label = "Interop Example",
                        Route = "/interop",
                        Order = 1
                    },
                    new MenuLink()
                    {
                        IconName = "fas fa-newspaper",
                        Label = "News example",
                        Route = "/portfolio",
                        Order = 2
                    },
                    new MenuLink()
                    {
                        IconName = "fas fa-sync-alt",
                        Label = "Data binding example",
                        Route = "/two-way",
                        Order = 3
                    },
                //    new MenuLink()
                //    {
                //        IconName = "fas fa-address-card",
                //        Label = "Contact",
                //        Route = "/contact",
                //        Order = 4
                //    }
                };

            base.OnInit();
        }
    }
}

using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using blazorfirststandaloneapplication.Services;
using blazor_first_standalone_application.Helpers;

namespace blazor_first_standalone_application
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddSingleton<IPortfolioCardService, PortfolioCardService>();
                //Helpers:
                services.AddSingleton<IPortfolioCardHelper, PortfolioCardHelper>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}

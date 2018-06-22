using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using blazorfirststandaloneapplication.shared.Models;
using blazorfirststandaloneapplication.Services;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Services;
using blazor_first_standalone_application.Helpers;

namespace blazorfirststandaloneapplication.Base
{
    public class PortfolioBase : BlazorComponent
    {
        [Inject]
        private IPortfolioCardService PortfolioCardService { get; set; }

        [Inject]
        private IUriHelper UriHelper { get; set; }

        [Inject]
        public IPortfolioCardHelper PortfolioCardHelper { get; set; }

        protected List<PortfolioCard> PortfolioCards { get; set; }

        protected override Task OnInitAsync()
        {
            PortfolioCards = PortfolioCardService.GetPortfolioCards();

            return base.OnInitAsync();
        }

        protected Action NavigateToCard(long cardId)
        {
            return () => UriHelper.NavigateTo($"portfolio/{cardId}");
        }
    }
}

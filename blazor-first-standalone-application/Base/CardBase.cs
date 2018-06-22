using System;
using System.Diagnostics;
using System.Threading.Tasks;
using blazorfirststandaloneapplication.shared.Models;
using blazorfirststandaloneapplication.Services;
using blazor_first_standalone_application.Helpers;
using Microsoft.AspNetCore.Blazor.Components;

namespace blazorfirststandaloneapplication.Base
{
    public class CardBase : BlazorComponent
    {
        [Inject]
        private IPortfolioCardService PortfolioCardService { get; set; }
        
        [Parameter]
        protected string CardId { get; set; }

        protected PortfolioCard Card { get; private set; }

        protected override Task OnInitAsync()
        {
            //parse on long (URI HAS STRING ONLY)
            var cardId = Convert.ToInt64(CardId);
            Card = PortfolioCardService.GetPortfolioCard(cardId);

            return base.OnInitAsync();
        }
    }
}

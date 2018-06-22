using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blazorfirststandaloneapplication.shared.Models;

namespace blazor_first_standalone_application.Helpers
{
    public interface IPortfolioCardHelper
    {
        string GetPortfolioCardImage(PortfolioCard card);
        string GetCardStyles(PortfolioCard card);
    }
}

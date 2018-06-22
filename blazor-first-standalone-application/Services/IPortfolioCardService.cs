using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blazorfirststandaloneapplication.shared.Models;

namespace blazorfirststandaloneapplication.Services
{
    public interface IPortfolioCardService
    {
        List<PortfolioCard> GetPortfolioCards();
        PortfolioCard GetPortfolioCard(long PortfolioCardId);

    }
}

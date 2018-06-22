using System;
using System.Text;
using blazorfirststandaloneapplication.shared.Models;

namespace blazor_first_standalone_application.Helpers
{
    public class PortfolioCardHelper : IPortfolioCardHelper
    {
        public string GetPortfolioCardImage(PortfolioCard card)
        {
            if (card.Image == null) return ""; //if no image (strange)

            if (card.Image.ImageUri != null) //if image is URI
            {
                return card.Image.ImageUri.AbsoluteUri;
            }

            if (card.Image.Data != null && card.Image.Data.Length > 0)
            {
                //if image is array of bytes.
                return $"data:{card.Image.MimeType};base64,{Convert.ToBase64String(card.Image.Data)}";
            }

            return ""; //if no image (strange)
        }

        public string GetCardStyles(PortfolioCard card)
        {
            var sb = new StringBuilder("card ");

            switch (card.ContentAlignment)
            {
                case PortfolioCardAlignment.Justify:
                    sb.Append("text-justify ");
                    break;
                case PortfolioCardAlignment.Right:
                    sb.Append("text-right ");
                    break;
                case PortfolioCardAlignment.Center:
                    sb.Append("text-center ");
                    break;
                default:
                    sb.Append("text-left ");
                    break;
            }

            if (card.Type == PortfolioCardType.Quote)
            {
                sb.Append("p-3 ");
            }

            return sb.ToString();
        }
    }
}

using System;

namespace blazorfirststandaloneapplication.shared.Models
{
    public class PortfolioCard
    {
        public long PortfolioCardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public PortfolioCardType Type { get; set; }

        public PortfolioCardAlignment ContentAlignment { get; set; }

        public long? ImageId { get; set; }

        public virtual Image Image { get; set; }

        public long? AuthorId { get; set; }

        public Uri Link { get; set; }

        public virtual User Author { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public enum PortfolioCardType
    {
        Image,
        Quote,
        Link,
        Article,
        Gallery,
        Normal
    }

    public enum PortfolioCardAlignment
    {
        Left,
        Center,
        Right,
        Justify
    }
}

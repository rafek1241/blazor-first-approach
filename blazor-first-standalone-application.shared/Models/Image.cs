using System;

namespace blazorfirststandaloneapplication.shared.Models
{
    public class Image
    {
        public long ImageId { get; set; }

        public string Filename { get; set; }

        public byte[] Data { get; set; }

        public Uri ImageUri { get; set; }

        public long? PortfolioCardId { get; set; }

        public virtual PortfolioCard PortfolioCard { get; set; }

        public string MimeType => string.IsNullOrEmpty(Filename) ? MimeTypes.GetMimeType(Filename) : null;
    }
}

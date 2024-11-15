namespace UrlShortnerAPI.Models
{
    public class ShortUrl
    {
        public Guid Id { get; set; }
        public string LongUrlp { get; set; } = string.Empty;
        public string ShortUrlp { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty ;
        public DateTime CreatedOnUtc { get; set; }
    }
}

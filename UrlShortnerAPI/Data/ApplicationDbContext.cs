using Microsoft.EntityFrameworkCore;
using UrlShortnerAPI.Helper;
using UrlShortnerAPI.Models;

namespace UrlShortnerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContext options)
            : base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShortUrl>(builder => {
                builder
                .Property(ShortUrl =>ShortUrl.Code)
                .HasMaxLength(ShortLinkSettings.Length);
                builder
                .HasIndex(ShortUrl => ShortUrl.Code)
                .IsUnique();
            });
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using WebPoznamky.Models;

namespace WebPoznamky.Data
{
    public class WebPoznamkyContext : DbContext
    {
        public WebPoznamkyContext(DbContextOptions<WebPoznamkyContext> options) : base(options) { }
        public DbSet<Uzivatel> Uzivatele { get; set; }
        public DbSet<Poznamka> Poznamky { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Poznamka>()
                .HasOne(c => c.Autor)
                .WithMany(a => a.Poznamky);
        }
    }
}
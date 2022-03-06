using Microsoft.EntityFrameworkCore;
using UniPortfolio.Entities;

namespace UniPortfolio.Services
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
        public DbSet<Mail> Mails { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace mf_zelo_2026.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Assembleia> Assembleias { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
    }
}

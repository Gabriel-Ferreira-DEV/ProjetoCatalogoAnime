using AnimeApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Anime> Animes => Set<Anime>();
        public DbSet<Plataforma> Plataformas => Set<Plataforma>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

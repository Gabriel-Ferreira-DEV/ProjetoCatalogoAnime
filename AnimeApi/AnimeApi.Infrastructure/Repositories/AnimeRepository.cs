
using AnimeApi.Entities;
using AnimeApi.Infrastructure.Context;
using AnimesApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Infrastructure.Repositories
{
    public class AnimesRepository : IAnimesRepository
    {
        private readonly AppDbContext _context;

        public AnimesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Anime>> GetAnimesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Animes
                .Include(a => a.Plataforma)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Anime?> GetAnimeAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Animes
                .Include(a => a.Plataforma)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        }

    }
}

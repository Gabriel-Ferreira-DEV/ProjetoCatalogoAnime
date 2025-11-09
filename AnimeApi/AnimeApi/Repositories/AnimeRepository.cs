using AnimeApi.Context;
using AnimeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AnimesApi.Repositories
{
    public class AnimesRepository : IAnimesRepository
    {
        private readonly AppDbContext _context;

        public AnimesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Anime>> GetAnimes(CancellationToken cancellationToken = default)
        {
            return await _context.Animes
                .Include(a => a.Plataforma)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Anime?> GetAnime(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Animes
                .Include(a => a.Plataforma)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Anime>> GetAnimesByPlataforma(int plataformaId, CancellationToken cancellationToken = default)
        {
            return await _context.Animes
                .Where(a => a.PlataformaId == plataformaId)
                .Include(a => a.Plataforma)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}

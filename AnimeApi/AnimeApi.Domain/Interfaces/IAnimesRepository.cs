using AnimeApi.Entities;

namespace AnimesApi.Repositories
{
    public interface IAnimesRepository
    {
        Task<IEnumerable<Anime>> GetAnimesAsync(CancellationToken cancellationToken = default);

        Task<Anime?> GetAnimeAsync(int id, CancellationToken cancellationToken = default);
    }
}
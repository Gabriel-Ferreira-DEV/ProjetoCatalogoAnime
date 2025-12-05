using AnimeApi.Entities;

namespace AnimesApi.Domain.Interfaces
{
    public interface IAnimesRepository
    {
        Task<IEnumerable<Anime>> GetAnimesAsync(CancellationToken cancellationToken = default);

        Task<Anime?> GetAnimeAsync(int id, CancellationToken cancellationToken = default);
    }
}
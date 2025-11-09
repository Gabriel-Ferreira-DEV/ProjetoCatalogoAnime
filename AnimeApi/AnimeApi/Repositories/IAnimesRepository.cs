using AnimeApi.Model;

namespace AnimesApi.Repositories
{
    public interface IAnimesRepository
    {
        Task<IEnumerable<Anime>> GetAnimes(CancellationToken cancellationToken = default);

        Task<Anime?> GetAnime(int id, CancellationToken cancellationToken = default);
    }
}
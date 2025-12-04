using AnimeApi.DTOs;

namespace AnimeApi.Application.Interfaces
{
    public interface IAnimesService
    {
        Task<IEnumerable<AnimeDTO>> GetAnimes(CancellationToken cancellationToken = default);

        Task<AnimeDTO?> GetAnime(int id, CancellationToken cancellationToken = default);
    }
}
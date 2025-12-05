

using AnimeApi.Application.Interfaces;
using AnimeApi.DTOs;
using AnimesApi.Domain.Interfaces;
using AutoMapper;

namespace AnimeApi.Application.Services
{
    public class AnimeService : IAnimesService
    {
        private IAnimesRepository _animesRepository;
        private readonly IMapper _mapper;

        public AnimeService(IAnimesRepository animesRepository, IMapper mapper)
        {
            _animesRepository = animesRepository;
            _mapper = mapper;
        }

        public async Task<AnimeDTO> GetAnime(int id, CancellationToken cancellationToken = default)
        {
            var anime = await _animesRepository.GetAnimeAsync(id, cancellationToken);
            var animeDto = _mapper.Map<AnimeDTO>(anime);
            return animeDto;

        }

        public async Task<IEnumerable<AnimeDTO>> GetAnimes(CancellationToken cancellationToken = default)
        {
            var animes = await _animesRepository.GetAnimesAsync(cancellationToken);
            var animesDto = _mapper.Map<IEnumerable<AnimeDTO>>(animes);
            return animesDto;
        }
    }
}

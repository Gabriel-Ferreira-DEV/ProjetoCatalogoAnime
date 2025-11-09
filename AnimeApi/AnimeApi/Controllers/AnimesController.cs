using AnimeApi.Context;
using AnimeApi.DTOs;
using AnimeApi.Model;
using AnimesApi.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnimesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anime>>> GetAll(CancellationToken cancellationToken)
        {
            try
            {
                var animes = await _unitOfWork.AnimesRepository.GetAnimes(cancellationToken);

                var animesDto = _mapper.Map<IEnumerable<AnimeDTO>>(animes);

                return Ok(animesDto);
            }
            catch (Exception ex)
            {
               return Problem("Erro ao obter animes do banco de dados", statusCode: 500);

            }
        }

        [HttpGet("{id:int}", Name = "GetAnime")]
        public async Task<ActionResult<Anime>> GetById(int id, CancellationToken cancellationToken)
        {
            try
            {
                var anime = await _unitOfWork.AnimesRepository.GetAnime(id,cancellationToken);

                if (anime == null)
                {
                    return NotFound($"Não existe anime com esse id = {id}");

                }
                var animeDTO = _mapper.Map<AnimeDTO>(anime);
                return Ok(animeDTO);
            }
            catch (Exception ex)
            {
                return Problem("Erro ao obter anime do banco de dados", statusCode: 500);
            }
        }
    }
}
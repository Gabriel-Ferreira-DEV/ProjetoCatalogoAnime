using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimeApi.Entities
{
    public class Plataforma
    {
        public int Id { get; set; }

        public string Nome { get; set; } = "";

        public string Url { get; set; } = "";

        public List<Anime> Animes { get; set; } = new();
    }
}
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimeApi.Model
{
    public class Plataforma
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = "";

        [Required]
        [StringLength(300)]
        public string Url { get; set; } = "";

        [Required]
        public List<Anime> Animes { get; set; } = new();
    }
}
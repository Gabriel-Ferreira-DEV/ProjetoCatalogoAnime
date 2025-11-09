using System.ComponentModel.DataAnnotations;

namespace AnimeApi.DTOs
{
    public class AnimeDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Titulo { get; set; } = "";

        [Required]
        [StringLength(2000)]
        public string Descricao { get; set; } = "";
        public string ImagemNome { get; set; } = "";
        public string? PlataformaNome { get; set; }
        public string? PlataformaUrl { get; set; }

    }
}

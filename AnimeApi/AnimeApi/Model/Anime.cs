using System.ComponentModel.DataAnnotations;

namespace AnimeApi.Model
{
    public class Anime
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Titulo { get; set; } = "";

        [Required]
        [StringLength(2000)]
        public string Descricao { get; set; } = "";

        [StringLength(150)]
        public string ImagemNome { get; set; } = "";

        public int PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; } = null!;
    }
}

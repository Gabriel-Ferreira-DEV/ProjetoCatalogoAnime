using System.ComponentModel.DataAnnotations;

namespace AnimeApi.DTOs
{
    public class PlataformaDTO
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = "";

        [Required]
        [StringLength(300)]
        public string Url { get; set; } = "";
    }
}

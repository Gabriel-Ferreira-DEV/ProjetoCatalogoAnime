using AnimeApi.Domain.Entities;
using AnimeApi.Domain.Validation;

namespace AnimeApi.Entities 
{
    public class Anime : Entity
    {
        public string Titulo { get; private set; } = "";
        public string Descricao { get; private set; } = "";
        public string ImagemNome { get; private set; } = "";
        public int PlataformaId { get; private set; }
        public Plataforma Plataforma { get; private set; } = null!;


        public Anime(string titulo, string descricao, string imagemNome, int plataformaId)
        {
            ValidarDominio(titulo, descricao, imagemNome, plataformaId);
        }


        public Anime(int id, string titulo, string descricao, string imagemNome, int plataformaId)
        {
            DomainExceptionValidation.When(id < 0, "O Id do anime é inválido.");
            Id = id;

            ValidarDominio(titulo, descricao, imagemNome, plataformaId);
        }

        private void ValidarDominio(string titulo, string descricao, string imagemNome, int plataformaId)
        {
            DomainExceptionValidation.When(
                string.IsNullOrWhiteSpace(titulo),
                "O título é obrigatório."
            );

            DomainExceptionValidation.When(
                string.IsNullOrWhiteSpace(descricao),
                "A descrição é obrigatória."
            );

            DomainExceptionValidation.When(
                plataformaId <= 0,
                "Plataforma inválida."
            );

            DomainExceptionValidation.When(
                imagemNome != null && imagemNome.Length > 150,
                "O nome da imagem não pode ultrapassar 150 caracteres."
            );

            Titulo = titulo;
            Descricao = descricao;
            ImagemNome = imagemNome ?? "";
            PlataformaId = plataformaId;
        }


        // Método para atualizar entidade com segurança
        public void Atualizar(string titulo, string descricao, string imagemNome, int plataformaId)
        {
            ValidarDominio(titulo, descricao, imagemNome, plataformaId);
        }
    }
}

using AnimeApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeApi.Infrastructure.EntitiesConfiguration
{
    internal class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.ToTable("Animes");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Titulo)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(a => a.Descricao)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            builder.Property(a => a.ImagemNome)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.HasOne(a => a.Plataforma)
                .WithMany(p => p.Animes)
                .HasForeignKey(a => a.PlataformaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using CadstroDeUsuario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadstroDeUsuario.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.Property(p => p.CEP).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Endereco");
            builder.Property(p => p.Logradouro).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Endereco");
            builder.Property(p => p.Cidade).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Endereco");
            builder.Property(p => p.Estado).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Endereco");
            builder.Property(p => p.Complemento).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Endereco");
            builder.Property(p => p.Bairro).HasColumnType("varchar(100)").IsRequired();
        }
    }
}

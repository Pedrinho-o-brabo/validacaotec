using CadstroDeUsuario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadstroDeUsuario.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.CPF).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Nascimento).HasColumnType("datetime2").IsRequired();
        }
    }
}

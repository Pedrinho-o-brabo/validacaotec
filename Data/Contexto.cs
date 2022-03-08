
using CadstroDeUsuario.Mappings;
using CadstroDeUsuario.Models;
using CadstroDeUsuario.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FormularioDeCadastro.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set;}

        
    }
}
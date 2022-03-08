namespace CadstroDeUsuario.Models
{
    public class Usuario
    {

        public int ID { get; set; }

        
        public String Nome { get; set; }
        
        public DateTime Nascimento { get; set; } = DateTime.Now;

        public String CPF { get; set; }

        public String Email { get; set; }

        public virtual Endereco Endereco { get; set; }

      

    }
}

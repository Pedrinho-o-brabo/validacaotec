namespace CadstroDeUsuario.Models
{
    public class Endereco
    {
     

       
        public int ID { get; set; }

        public String CEP { get; set; }

        public String Logradouro { get; set; }

        public String Complemento { get; set; }
        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
        

        
    }
}

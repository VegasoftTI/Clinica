namespace Clinica.API.Models
{
    public abstract class Pessoa : Entidade
    {
        public string  Nome { get; set; }
        public string  Email { get; set; }     
    }
}
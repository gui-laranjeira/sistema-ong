using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
       
        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }

        public int Idade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool Voluntario { get; set; }

        [Required]
        public bool Newsletter { get; set; }

        public DateTime DataDeInscrição { get; set; } = DateTime.Now;
    }
}

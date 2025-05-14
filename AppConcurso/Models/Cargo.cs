using System.ComponentModel.DataAnnotations;

namespace AppConcurso.Models
{
    public class Cargo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string NomeCargo { get; set; }

        [MaxLength(60)]
        public string Edital { get; set; }

        public decimal SalarioBase { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
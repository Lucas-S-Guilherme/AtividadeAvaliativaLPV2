using System.ComponentModel.DataAnnotations;

namespace AppConcurso.Models
{
    public class Candidato
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(45)]
        public string Cpf { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
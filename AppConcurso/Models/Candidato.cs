using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("candidato")]
    public class Candidato
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("nome")]
        [MaxLength(45)]
        public string? Nome { get; set; }

        [Required]
        [Column("cpf")]
        [MaxLength(45)]
        public string? Cpf { get; set; }

        [Column("data_nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public ICollection<Inscricao>? Inscricoes { get; set; }
    }
}
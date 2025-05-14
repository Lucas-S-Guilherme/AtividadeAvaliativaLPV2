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

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Column("nome")]
        [MaxLength(45)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [Column("cpf")]
        [MaxLength(45)]
        public string? Cpf { get; set; }

        [Column("data_nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public DateTime DataNascimento { get; set; }

        public ICollection<Inscricao>? Inscricoes { get; set; }
    }
}
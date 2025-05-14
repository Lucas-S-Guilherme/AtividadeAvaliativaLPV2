using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("cargo")]
    public class Cargo
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("nome_cargo")]
        [MaxLength(45)]
        public string? NomeCargo { get; set; }

        [Column("edital")]
        [MaxLength(60)]
        public string? Edital { get; set; }

        [Column("salario_base")]
        public decimal SalarioBase { get; set; }

        public ICollection<Inscricao>? Inscricoes { get; set; }
    }
}
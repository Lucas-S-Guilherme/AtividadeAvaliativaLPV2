using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("inscricao")]
    public class Inscricao
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("numero_insc")]
        [MaxLength(45)]
        public string? NumeroInsc { get; set; }

        [Column("data_inscricao")]
        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; set; }

        [Column("nota_conh_gerais")]
        public decimal NotaConhGerais { get; set; }

        [Column("nota_conh_especificos")]
        public decimal NotaConhEspecificos { get; set; }

        [ForeignKey("candidato_id_fk")]
        [Column("candidato_id_fk")]
        public int CandidatoIdFk { get; set; }
        public Candidato? Candidato { get; set; }

        [ForeignKey("cargo_id_fk")]
        [Column("cargo_id_fk")]
        public int CargoIdFk { get; set; }
        public Cargo? Cargo { get; set; }
    }
}
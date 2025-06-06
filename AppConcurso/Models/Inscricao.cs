using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("inscricao")]
    public class Inscricao
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("numero_insc")]
        public int? NumInscricao { get; set; }

        [Column("data_inscricao")]
        public DateTime? DataInsc { get; set; }

        [Column("nota_conh_gerais")]
        public decimal? NotaConhGerais { get; set; }

        [Column("nota_conh_especificos")]
        public decimal? NotaConhEspec { get; set; }

        [Column("candidato_id_fk")]
        public int IdCandidato { get; set; }

        [ForeignKey("IdCandidato")]
        public Candidato? Candidato { get; set; }

        [Column("cargo_id_fk")]
        public int IdCargo { get; set; }

        [ForeignKey("IdCargo")]
        public Cargo? Cargo { get; set; }
        [NotMapped]
        public decimal? Total => (NotaConhGerais ?? 0) + (NotaConhEspec ?? 0);
    }
}
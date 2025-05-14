using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    public class Inscricao
    {
        public int Id { get; set; }

        [MaxLength(45)]
        public string NumeroInsc { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInscricao { get; set; }

        public decimal NotaConhGerais { get; set; }

        public decimal NotaConhEspecificos { get; set; }

        [ForeignKey("Candidato")]
        public int CandidatoIdFk { get; set; }
        public Candidato Candidato { get; set; }

        [ForeignKey("Cargo")]
        public int CargoIdFk { get; set; }
        public Cargo Cargo { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    [Table("Contas")]
    public class Contas
    {
        [Key]
        public Guid ContaId { get; set; }
        [Required]
        public int Tipo { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CriadoEm { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FinalizaEm { get; set; }

        [ForeignKey("Clientes")]
        public Guid ClienteId { get; set; }
        public Clientes Cliente { get; set;}

        public Logs Log { get; set; }

        public IEnumerable<Linhas> Linhas { get; set; }
    }
}

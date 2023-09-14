using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("ClienteServico")]
    public class ClienteServico
    {

        [Key]
        public Guid ServicosContratadosId { get; set; }

        [ForeignKey("Cliente")]
        public Guid ClienteId { get; set; }

        [ForeignKey("Servico")]
        public Guid ServicoId { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Servico? Servico { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Servicos")]
    public class Servico
    {
        public Servico()
        {
            ClienteServico = new HashSet<ClienteServico>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public float Preco { get; set; }
        [Required]
        public int Tipo { get; set; }

        public virtual ICollection<ClienteServico>? ClienteServico { get; set; }
    }
}

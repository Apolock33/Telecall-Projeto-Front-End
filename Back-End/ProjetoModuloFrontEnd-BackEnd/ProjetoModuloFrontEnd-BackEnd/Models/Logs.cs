using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    [Table("Logs")]
    public class Logs
    {
        [Key]
        public Guid LogId { get; set; }
        [Required]
        public string? Operacao { get; set; }
        [Required]
        public bool? Sucesso { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OcorridoEm { get; set; }

        [ForeignKey("Usuarios")]
        public Guid UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }
    }
}

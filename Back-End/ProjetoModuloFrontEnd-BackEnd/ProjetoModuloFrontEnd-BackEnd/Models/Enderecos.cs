using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    [Table("Enderecos")]
    public class Enderecos
    {
        [Key]
        public Guid EnderecoId { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Rua { get; set; }
        [Required]
        public int? Numero { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        [Required]
        public string? Cidade { get; set; }
        [Required]
        public string? Estado { get; set; }


        [ForeignKey("Usuarios")]
        public Guid UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }

        [ForeignKey("Clientes")]
        public Guid ClienteId { get; set; }
        public Clientes Cliente { get; set; }
    }
}

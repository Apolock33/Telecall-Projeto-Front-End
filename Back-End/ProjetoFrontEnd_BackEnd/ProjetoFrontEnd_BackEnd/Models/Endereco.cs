using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public Guid EnderecoId { get; set; }

        [Required]
        [ForeignKey("Usuarios")]
        public Guid UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [Required]
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        [Required]
        public string? Cidade { get; set; }
        [Required]
        public string? Estado { get; set; }
    }
}

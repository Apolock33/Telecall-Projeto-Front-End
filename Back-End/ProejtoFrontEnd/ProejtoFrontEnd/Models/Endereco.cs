using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public Guid EnderecoId { get; set; }
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public Guid? UsuarioId { get; set; }
    }
}

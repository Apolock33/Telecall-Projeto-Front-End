using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Nome { get; set; }
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Documento { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Phone { get; set; }
    }
}

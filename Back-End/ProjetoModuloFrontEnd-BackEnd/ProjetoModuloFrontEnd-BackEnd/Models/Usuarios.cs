using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public Guid UsuarioId { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Nome { get; set; }
        [Required]
        public int Sexo { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Documento { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? NomeMaterno { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Celular { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Fixo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? CriadoEm { get; set; }

        public Enderecos Endereco { get; set; }
    }
}

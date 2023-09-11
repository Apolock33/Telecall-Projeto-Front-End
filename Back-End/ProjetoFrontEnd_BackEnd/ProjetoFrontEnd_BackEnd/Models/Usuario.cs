using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }
        [Required]
        [MinLength(15, ErrorMessage = "O número mínimo de caracteres foi não  foi atingido")]
        [StringLength(60, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Nome { get; set; }
        [Required]
        public string? Sexo { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Documento { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Celular { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Fixo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? NomeMaterno { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Login { get; set; }
        [Required]
        public string? Senha { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CriadoEm { get; set; }

        public Endereco Endereco { get; set; }
    }
}

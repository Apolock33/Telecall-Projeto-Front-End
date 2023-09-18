using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFrontEnd_BackEnd.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }
        [MinLength(15, ErrorMessage = "O número mínimo de caracteres foi não  foi atingido")]
        [StringLength(60, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Nome { get; set; }
        public string? Sexo { get; set; }
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Documento { get; set; }
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Celular { get; set; }
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Fixo { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string? NomeMaterno { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        [DefaultValue(1)]
        public int Tipo { get; set; }
        [DefaultValue("123456")]
        public string? CodigoDeValidacao { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CriadoEm { get; set; }
    }
}

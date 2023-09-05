using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    [Table("Linhas")]
    public class Linhas
    {
        [Key]
        public Guid LinhaId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Number { get; set; }
        [StringLength(200, ErrorMessage = "O número máximo de caracteres foi atingido")]
        public string? Surname { get; set; }
        [Required]
        public int Iccid { get; set; }
        [Required]
        public int Status { get; set; }

        [ForeignKey("Contas")]
        public Guid ContaId { get; set; }
        public Contas Conta { get; set; }
    }
}

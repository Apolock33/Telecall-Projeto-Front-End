using ProejtoFrontEnd.Models.Enums;
using ProjetoFrontEnd_BackEnd.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace ProejtoFrontEnd.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public TipoDeErro TipoDeErro { get; set; }
        public string? Mensagem { get; set; }
        public string? DetalhamentoDeErro { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}

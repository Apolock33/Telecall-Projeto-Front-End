using ProejtoFrontEnd.Models.Enums;

namespace ProejtoFrontEnd.Models.DTOs
{
    public class LogDTO
    {
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public TipoDeErro TipoDeErro { get; set; }
        public string? Mensagem { get; set; }
        public string? DetalhamentoDeErro { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}

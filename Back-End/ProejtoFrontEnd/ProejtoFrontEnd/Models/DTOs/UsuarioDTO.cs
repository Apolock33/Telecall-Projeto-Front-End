using ProjetoFrontEnd_BackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFrontEnd_BackEnd.DTOs
{
    public class UsuarioDTO
    {

        public Guid UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? Sexo { get; set; }
        public string? Documento { get; set; }
        public string? Celular { get; set; }
        public string? Fixo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? NomeMaterno { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}

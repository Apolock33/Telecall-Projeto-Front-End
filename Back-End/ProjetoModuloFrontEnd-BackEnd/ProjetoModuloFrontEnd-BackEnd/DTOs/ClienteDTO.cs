using ProjetoModuloFrontEnd_BackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModuloFrontEnd_BackEnd.DTOs
{
    public class ClienteDTO
    {
        public Guid? ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public Enderecos? Endereco { get; set; }

        public IEnumerable<Contas>? Contas { get; set; }
    }
}

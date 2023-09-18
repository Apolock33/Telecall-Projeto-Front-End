using ProjetoFrontEnd_BackEnd.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFrontEnd_BackEnd.DTOs
{
    public class EnderecoDTO
    {
        public Guid EnderecoId { get; set; }

        public Guid UsuarioId { get; set; }
        public UsuarioDTO? Usuario { get; set; }

        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}

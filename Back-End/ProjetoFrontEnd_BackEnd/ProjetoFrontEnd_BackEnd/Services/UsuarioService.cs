using ProjetoFrontEnd_BackEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Services.Interfaces;

namespace ProjetoFrontEnd_BackEnd.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IEnderecoRepository enderecoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _enderecoRepository = enderecoRepository;
        }
    }
}

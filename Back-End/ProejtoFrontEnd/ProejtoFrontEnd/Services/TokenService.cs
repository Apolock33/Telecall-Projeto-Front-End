using Microsoft.IdentityModel.Tokens;
using ProjetoFrontEnd_BackEnd.Models;
using ProjetoFrontEnd_BackEnd.Models.JWT;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Net;

namespace ProejtoFrontEnd.Services
{
    public class TokenService
    {
        public static object GenerateToken(Usuario usuario)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UsuarioId", usuario.UsuarioId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public static Resposta<string> Secret()
        {
            var resposta = new Resposta<string>();

            var list = new List<string>();

            try
            {
                int keySizeInBytes = 64;

                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    byte[] keyBytes = new byte[keySizeInBytes];

                    rng.GetBytes(keyBytes);

                    string base64Key = Convert.ToBase64String(keyBytes);

                    list.Add(base64Key);

                    resposta.Success = true;
                    resposta.StatusCode = HttpStatusCode.OK;
                    resposta.Data = list;
                    resposta.Message = "Chave gerada";

                    return resposta;
                }
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = list;
                resposta.Message = $"Chave não gerada. Detalhamento de erro: {ex.Message}";

                return resposta;
            }
        }
    }
}

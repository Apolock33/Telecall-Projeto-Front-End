
using System.ComponentModel;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Models
{
    public class Respostas<T>
    {
        [DefaultValue(false)]
        public bool Success { get; set; }
        [DefaultValue(HttpStatusCode.BadRequest)]
        public HttpStatusCode? StatusCode { get; set; }
        [DefaultValue(null)]
        public List<T>? Data { get; set; }
        [DefaultValue("")]
        public string? Message { get; set; }
    }

    public class RespostaUsuario
    {
        [DefaultValue(true)]
        public bool Success { get; set; }
        [DefaultValue(HttpStatusCode.OK)]
        public HttpStatusCode? StatusCode { get; set; }
        [DefaultValue(null)]
        public string? Token { get; set; }
        [DefaultValue(null)]
        public string? Message { get; set; }
    }
}
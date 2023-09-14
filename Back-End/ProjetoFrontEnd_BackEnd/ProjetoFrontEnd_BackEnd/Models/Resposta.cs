using System.ComponentModel;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Models
{
    public class Resposta<T>
    {
        [DefaultValue(true)]
        public bool Success { get; set; }
        [DefaultValue(HttpStatusCode.OK)]
        public HttpStatusCode? StatusCode { get; set; }
        [DefaultValue(null)]
        public T? Data { get; set; }
        [DefaultValue(null)]
        public string? Message { get; set; }
    }
}
using System.ComponentModel;
using System.Net;

namespace ProjetoFrontEnd_BackEnd.Models
{
    internal class Resposta<T>
    {
        public bool Success { get; set; }
        public HttpStatusCode? StatusCode { get; set; }
        [DefaultValue(null)]
        public T? Data { get; set; }
        public string? Message { get; set; }
    }
}
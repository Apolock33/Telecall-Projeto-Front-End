using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Net;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    public class Resposta<T>
    {
        public bool Success { get; set; }
        public HttpStatusCode? StatusCode { get; set; }
        [DefaultValue(null)]
        public T? Data { get; set; }
        public string? Message { get; set; }
    }
}

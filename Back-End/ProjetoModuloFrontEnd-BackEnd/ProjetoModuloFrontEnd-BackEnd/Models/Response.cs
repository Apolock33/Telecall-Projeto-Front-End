using Microsoft.AspNetCore.Mvc;

namespace ProjetoModuloFrontEnd_BackEnd.Models
{
    public class Response
    {
        public bool Success { get; set; }
        public StatusCodeResult? StatusCode { get; set; }
        public string? Message { get; set; }
    }
}

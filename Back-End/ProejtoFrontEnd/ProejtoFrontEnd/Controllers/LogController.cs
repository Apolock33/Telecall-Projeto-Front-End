using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Models;
using ProejtoFrontEnd.Models.DTOs;
using ProejtoFrontEnd.Services.Interfaces;
using ProjetoFrontEnd_BackEnd.Models;
using System.Net;

namespace ProejtoFrontEnd.Controllers
{
    [ApiController]
    [Route("Log")]
    public class LogController : Controller
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet("ListarLogs")]
        public async Task<IActionResult> ListarLogs()
        {
            var resposta = new Resposta<LogDTO>();

            try
            {
                var getAll = await _logService.GetAllLogs();

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = getAll.ToList();
                resposta.Message = "Lista de Logs Recuperada";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<LogDTO>();
                resposta.Message = $"Falha ao recuperar lista de logs. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }

        [HttpPost("CriarLogs")]
        public async Task<IActionResult> CriarLogs(LogDTO log)
        {
            var resposta = new Resposta<LogDTO>();

            var listaLogDto = new List<LogDTO>();

            try
            {
                var getAll = await _logService.PostLog(log);

                listaLogDto.Add(getAll);

                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.OK;
                resposta.Data = listaLogDto;
                resposta.Message = "";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.Success = true;
                resposta.StatusCode = HttpStatusCode.BadRequest;
                resposta.Data = new List<LogDTO>();
                resposta.Message = $"Falha ao recuperar criar log. Detalhamento de erro: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}

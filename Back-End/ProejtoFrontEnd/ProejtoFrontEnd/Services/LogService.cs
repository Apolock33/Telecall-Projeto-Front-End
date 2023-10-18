using ProejtoFrontEnd.Models;
using ProejtoFrontEnd.Models.DTOs;
using ProejtoFrontEnd.Repositories.Interfaces;
using ProejtoFrontEnd.Services.Interfaces;

namespace ProejtoFrontEnd.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;
        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task<IEnumerable<LogDTO>> GetAllLogs()
        {
            var logDto = new LogDTO();

            var listaLogDto = new List<LogDTO>();

            var getAll = await _logRepository.GetAll();

            foreach (var item in getAll)
            {
                logDto.Id = item.Id;
                logDto.TipoDeErro = item.TipoDeErro;
                logDto.Mensagem = item.Mensagem;
                logDto.DetalhamentoDeErro = item?.DetalhamentoDeErro;
                logDto.CriadoEm = item.CriadoEm;
                logDto.UsuarioId = item.UsuarioId;

                listaLogDto.Add(logDto);
            }

            return listaLogDto;
        }

        public async Task<LogDTO> PostLog(LogDTO log)
        {
            var logDto = new LogDTO();

            var logEntity = new Log();

            logEntity.Id = log.Id;
            logEntity.TipoDeErro = log.TipoDeErro;
            logEntity.Mensagem = log.Mensagem;
            logEntity.DetalhamentoDeErro = log?.DetalhamentoDeErro;
            logEntity.CriadoEm = log.CriadoEm;
            logEntity.UsuarioId = log.UsuarioId;

            var criarLog = await _logRepository.Add(logEntity);

            logDto.Id = log.Id;
            logDto.TipoDeErro = log.TipoDeErro;
            logDto.Mensagem = log.Mensagem;
            logDto.DetalhamentoDeErro = log?.DetalhamentoDeErro;
            logDto.CriadoEm = log.CriadoEm;
            logDto.UsuarioId = log.UsuarioId;

            return logDto;
        }
    }
}

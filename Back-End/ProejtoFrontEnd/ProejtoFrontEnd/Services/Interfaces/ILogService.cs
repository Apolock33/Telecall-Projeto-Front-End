using ProejtoFrontEnd.Models;
using ProejtoFrontEnd.Models.DTOs;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogDTO> PostLog(Log log);
        Task<IEnumerable<LogDTO>> GetAllLogs();
    }
}

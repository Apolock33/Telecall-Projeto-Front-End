using ProejtoFrontEnd.Models;
using ProejtoFrontEnd.Models.DTOs;

namespace ProejtoFrontEnd.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogDTO> PostLog(LogDTO log);
        Task<IEnumerable<LogDTO>> GetAllLogs();
    }
}

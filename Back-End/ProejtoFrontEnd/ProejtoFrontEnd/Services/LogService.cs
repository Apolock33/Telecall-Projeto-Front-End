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
    }
}

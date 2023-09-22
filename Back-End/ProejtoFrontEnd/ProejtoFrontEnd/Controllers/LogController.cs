using Microsoft.AspNetCore.Mvc;
using ProejtoFrontEnd.Services.Interfaces;

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
    }
}

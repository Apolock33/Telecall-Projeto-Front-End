using ProejtoFrontEnd.Models;
using ProejtoFrontEnd.Repositories.Interfaces;
using ProjetoFrontEnd_BackEnd.Models.Context;

namespace ProejtoFrontEnd.Repositories
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        public LogRepository(AppDbContext db) : base(db)
        {
        }
    }
}

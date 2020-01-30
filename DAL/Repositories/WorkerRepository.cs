using DAL.Repositories.Interfaces;
using Database;
using Database.Models;

namespace DAL.Repositories
{
    public class WorkerRepository : RepositoryBase<Worker>, IWorkerRepository
    {
        public WorkerRepository(AppContext context)
            : base(context)
        {
        }
    }
}
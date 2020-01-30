using System.Linq;
using DAL.Repositories.Interfaces;
using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OfficeRepository : RepositoryBase<Office>, IOfficeRepository
    {
        public OfficeRepository(AppContext context)
            : base(context)
        {
        }

        public Office GetOfficeWithWorkersByOfficeId(int id)
        {
            var result = RepositoryContext.Offices
                .Include(x => x.Workers)
                .ThenInclude(x => x.WorkerHobbies).ThenInclude(x => x.Hobby).FirstOrDefault(y => y.OfficeId == id);

            return result;
        }
    }
}
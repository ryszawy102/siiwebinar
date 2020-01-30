using DAL.Repositories.Interfaces;
using Database;
using Database.Models;

namespace DAL.Repositories
{
    public class HobbyRepository : RepositoryBase<Hobby>, IHobbyRepository
    {
        public HobbyRepository(AppContext context)
            : base(context)
        {
        }
    }
}
using Database.Models;

namespace DAL.Repositories.Interfaces
{
    public interface IOfficeRepository : IRepositoryBase<Office>
    {
        Office GetOfficeWithWorkersByOfficeId(int id);
    }
}
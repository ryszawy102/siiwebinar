using System;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOfficeRepository Offices { get; }
        IWorkerRepository Workers { get; }
        IHobbyRepository Hobbies { get; }
        Task<int> SaveChangesAsync();
    }
}
using System;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;
using AppContext = Database.AppContext;

namespace DAL.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private AppContext _appContext;
        private IHobbyRepository _hobbyRepository;
        private IOfficeRepository _officeRepository;
        private IWorkerRepository _workerRepository;

        public UnitOfWork(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IOfficeRepository Offices =>
            _officeRepository ?? (_officeRepository = new OfficeRepository(_appContext));

        public IWorkerRepository Workers =>
            _workerRepository ?? (_workerRepository = new WorkerRepository(_appContext));

        public IHobbyRepository Hobbies =>
            _hobbyRepository ?? (_hobbyRepository = new HobbyRepository(_appContext));

        public Task<int> SaveChangesAsync()
        {
            return _appContext.SaveChangesAsync();
        }

        /// <summary>
        ///     Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
                if (_appContext != null)
                {
                    _appContext.Dispose();
                    _appContext = null;
                }
        }
    }
}
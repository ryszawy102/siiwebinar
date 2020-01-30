using System.Collections.Generic;
using Infrastructure.Models;

namespace Infrastructure.Services.Interfaces
{
    public interface IWorkerService
    {
        List<WorkerDto> GetListofWorkrVmsByOfficeId(int officeId);
    }
}
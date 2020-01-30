using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DAL.Repositories.Interfaces;
using Infrastructure.Models;
using Infrastructure.Services.Interfaces;

namespace Infrastructure.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public WorkerService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public List<WorkerDto> GetListofWorkrVmsByOfficeId(int officeId)
        {
            var model = _unitOfWork.Workers.FindByCondition(x => x.OfficeId == officeId).ToList();
            var result = _mapper.Map<List<WorkerDto>>(model);
            return result;
        }
    }
}
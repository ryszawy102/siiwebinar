using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Repositories.Interfaces;
using Infrastructure.Models;
using Infrastructure.Services.Interfaces;

namespace Infrastructure.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OfficeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public OfficeDto GetOfficeDtoById(int id)
        {
            var model = _unitOfWork.Offices.FindByCondition(x => x.OfficeId == id).FirstOrDefault();
            var result = _mapper.Map<OfficeDto>(model);
            return result;
        }

        public List<OfficeDto> GetOfficesOfficeVms()
        {
            var model = _unitOfWork.Offices.FindAll().ToList();
            var result = _mapper.Map<List<OfficeDto>>(model);
            return result;
        }

        public async Task<List<OfficeDto>> GetOfficesListDtoAsync()
        {
            var model = await _unitOfWork.Offices.FindAllAsync();
            var result = _mapper.Map<List<OfficeDto>>(model);
            return result;
        }

        public OfficeWithWorkersDto GetOfficeWithWorkersVm(int officeId)
        {
            var model = _unitOfWork.Offices.GetOfficeWithWorkersByOfficeId(officeId);
            var result = _mapper.Map<OfficeWithWorkersDto>(model);
            return result;
        }
    }
}
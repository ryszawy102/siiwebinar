using AutoMapper;
using DAL.Repositories.Interfaces;
using Infrastructure.Services.Interfaces;

namespace Infrastructure.Services
{
    public class HobbyService : IHobbyService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public HobbyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
using System.Linq;
using AutoMapper;
using Database.Models;
using Infrastructure.Models;

namespace Infrastructure
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Office, OfficeDto>();


            CreateMap<Office, OfficeWithWorkersDto>()
                .ForMember(dest => dest.Office, opt => opt.MapFrom(res => res));


            CreateMap<Worker, WorkerDto>()
                .ForMember(dto => dto.Hobbies, opt => opt.MapFrom(x => x.WorkerHobbies.Select(a => a.Hobby)));


            CreateMap<Hobby, HobbyDto>();
        }
    }
}
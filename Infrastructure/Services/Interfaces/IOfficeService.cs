using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Services.Interfaces
{
    public interface IOfficeService
    {
        OfficeDto GetOfficeDtoById(int id);
        List<OfficeDto> GetOfficesOfficeVms();
        Task<List<OfficeDto>> GetOfficesListDtoAsync();
        OfficeWithWorkersDto GetOfficeWithWorkersVm(int officeId);
    }
}
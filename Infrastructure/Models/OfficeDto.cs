using System.Collections.Generic;

namespace Infrastructure.Models
{
    public class OfficeDto
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public string OfficeStreet { get; set; }
        public string OfficePostCode { get; set; }
        public string OfficeCity { get; set; }
        public string OfficeReceptionTelephone { get; set; }
        public string OfficeEmail { get; set; }
        public int OpenYear { get; set; }
        public List<WorkerDto> Workers { get; set; }
    }
}
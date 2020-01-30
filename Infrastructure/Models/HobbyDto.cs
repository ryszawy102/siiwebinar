using System.Collections.Generic;

namespace Infrastructure.Models
{
    public class HobbyDto
    {
        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
        public string TypeOfRisk { get; set; }

        public virtual List<WorkersHobbyDto> WorkersHobbyDtos { get; set; }
    }
}
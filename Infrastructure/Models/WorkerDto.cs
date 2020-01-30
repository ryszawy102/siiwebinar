using System.Collections.Generic;

namespace Infrastructure.Models
{
    public class WorkerDto
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public List<HobbyDto> Hobbies { get; set; }
    }
}
namespace Infrastructure.Models
{
    public class WorkersHobbyDto
    {
        public int WorkerId { get; set; }
        public WorkerDto Worker { get; set; }
        public int HobbyId { get; set; }
        public HobbyDto Hobby { get; set; }
    }
}

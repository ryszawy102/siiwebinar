namespace Database.Models
{
    public class WorkerHobby
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }
    }
}
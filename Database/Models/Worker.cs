using System.Collections.Generic;

namespace Database.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public Office Office { get; set; }
        public int OfficeId { get; set; }
        public virtual ICollection<WorkerHobby> WorkerHobbies { get; set; }
    }
}
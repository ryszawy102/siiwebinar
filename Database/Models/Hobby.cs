using System.Collections.Generic;

namespace Database.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
        public string TypeOfRisk { get; set; }
        public virtual ICollection<WorkerHobby> WorkerHobbies { get; set; }
    }
}
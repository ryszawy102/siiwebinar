using Database.Models;

namespace Database.Seeds
{
    internal static class HobbySeeds
    {
        internal static Hobby[] GetHobbySeeds()
        {
            var hobbies = new[]
            {
                new Hobby
                {
                    HobbyId = 1,
                    HobbyName = "Football"
                },
                new Hobby
                {
                    HobbyId = 2,
                    HobbyName = "Volleyball"
                },
                new Hobby
                {
                    HobbyId = 3,
                    HobbyName = "Basketball"
                },
                new Hobby
                {
                    HobbyId = 4,
                    HobbyName = "Fashion"
                },
                new Hobby
                {
                    HobbyId = 5,
                    HobbyName = "Reading books"
                },
                new Hobby
                {
                    HobbyId = 6,
                    HobbyName = "Book writer"
                },
                new Hobby
                {
                    HobbyId = 7,
                    HobbyName = "Shooting"
                },
                new Hobby
                {
                    HobbyId = 8,
                    HobbyName = "Traveling"
                },
                new Hobby
                {
                    HobbyId = 9,
                    HobbyName = "His Wife ;)"
                },
                new Hobby
                {
                    HobbyId = 10,
                    HobbyName = "Mountain hiker"
                }
            };

            return hobbies;
        }
    }
}
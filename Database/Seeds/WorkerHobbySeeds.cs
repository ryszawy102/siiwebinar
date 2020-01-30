using Database.Models;

namespace Database.Seeds
{
    internal static class WorkerHobbySeeds
    {
        internal static WorkerHobby[] GetWorkerHobbySeeds()
        {
            var workerHobbies = new[]
            {
                new WorkerHobby
                {
                    WorkerId = 1,
                    HobbyId = 1
                },
                new WorkerHobby
                {
                    WorkerId = 1,
                    HobbyId = 5
                },
                new WorkerHobby
                {
                    WorkerId = 1,
                    HobbyId = 7
                },
                new WorkerHobby
                {
                    WorkerId = 2,
                    HobbyId = 4
                },
                new WorkerHobby
                {
                    WorkerId = 2,
                    HobbyId = 10
                },
                new WorkerHobby
                {
                    WorkerId = 2,
                    HobbyId = 2
                },
                new WorkerHobby
                {
                    WorkerId = 3,
                    HobbyId = 8
                },
                new WorkerHobby
                {
                    WorkerId = 3,
                    HobbyId = 9
                },
                new WorkerHobby
                {
                    WorkerId = 3,
                    HobbyId = 1
                },
                new WorkerHobby
                {
                    WorkerId = 3,
                    HobbyId = 10
                },
                new WorkerHobby
                {
                    WorkerId = 4,
                    HobbyId = 10
                },
                new WorkerHobby
                {
                    WorkerId = 4,
                    HobbyId = 7
                },
                new WorkerHobby
                {
                    WorkerId = 5,
                    HobbyId = 1
                }
            };
            return workerHobbies;
        }
    }
}
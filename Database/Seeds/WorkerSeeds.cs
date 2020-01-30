using Database.Models;

namespace Database.Seeds
{
    internal static class WorkerSeeds
    {
        internal static Worker[] GetWorkerSeeds()
        {
            var workers = new[]
            {
                new Worker
                {
                    WorkerId = 1,
                    WorkerName = "Filip",
                    WorkerSurname = "Sygula",
                    OfficeId = 3
                },
                new Worker
                {
                    WorkerId = 2,
                    WorkerName = "Katarzyna",
                    WorkerSurname = "C",
                    OfficeId = 3
                },
                new Worker
                {
                    WorkerId = 3,
                    WorkerName = "Zbigniew",
                    WorkerSurname = "L",
                    OfficeId = 3
                },

                new Worker
                {
                    WorkerId = 4,
                    WorkerName = "Big",
                    WorkerSurname = "Boss",
                    OfficeId = 1
                },

                new Worker
                {
                    WorkerId = 5,
                    WorkerName = "Big",
                    WorkerSurname = "Supervisor",
                    OfficeId = 1
                },
            };

            return workers;
        }
    }
}
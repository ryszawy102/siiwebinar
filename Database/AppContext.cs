using Database.Models;
using Database.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public AppContext()
        {
        }

        public DbSet<Office> Offices { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>()
                .HasMany(c => c.Workers)
                .WithOne(e => e.Office);

            modelBuilder.Entity<WorkerHobby>()
                .HasKey(wh => new {wh.HobbyId, wh.WorkerId});
            modelBuilder.Entity<WorkerHobby>()
                .HasOne(wh => wh.Worker)
                .WithMany(b => b.WorkerHobbies)
                .HasForeignKey(wh => wh.WorkerId);
            modelBuilder.Entity<WorkerHobby>()
                .HasOne(wh => wh.Hobby)
                .WithMany(c => c.WorkerHobbies)
                .HasForeignKey(wh => wh.HobbyId);


            modelBuilder.Entity<Office>().HasData(OfficeSeeds.GetOfficeSeeds());
            modelBuilder.Entity<Worker>().HasData(WorkerSeeds.GetWorkerSeeds());
            modelBuilder.Entity<Hobby>().HasData(HobbySeeds.GetHobbySeeds());
            modelBuilder.Entity<WorkerHobby>().HasData(WorkerHobbySeeds.GetWorkerHobbySeeds());
        }
    }
}
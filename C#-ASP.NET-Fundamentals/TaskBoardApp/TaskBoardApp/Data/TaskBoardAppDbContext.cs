using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data.Entities;
using Task = TaskBoardApp.Data.Entities.Task;

namespace TaskBoardApp.Data
{
    public class TaskBoardAppDbContext : IdentityDbContext<User>
    {

        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        private User GuestUser { get; set; }
        private Board OpenBoard { get; set; }
        private Board InProcessBoard { get; set; }
        private Board DoneBoard { get; set; }


        public DbSet<Task> Tasks { get; set; }
        public DbSet<Board> Boards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Task>()
                .HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoardId)
                .OnDelete(DeleteBehavior.Restrict);

            SeedUsers();
            builder
                .Entity<User>()
                .HasData(this.GuestUser);

            SeedBoards();
            builder
                .Entity<Board>()
                .HasData(this.OpenBoard, this.InProcessBoard, this.DoneBoard);

            builder
                .Entity<Task>()
                .HasData(new Task()
                {
                    Id = 1,
                    Title = "Prepare for ASP.NET",
                    Description = "Learn using Identity",
                    CreatedOn = DateTime.Now.AddMonths(-1),
                    OwnerId = this.GuestUser.Id,
                    BoardId = this.OpenBoard.Id
                },
                new Task()
                {
                    Id = 2,
                    Title = "Improve EfCore",
                    Description = "Learn using Ef core",
                    CreatedOn = DateTime.Now.AddMonths(-5),
                    OwnerId = this.GuestUser.Id,
                    BoardId = this.DoneBoard.Id
                },
                new Task()
                {
                    Id = 3,
                    Title = "Improve AspNEt skills",
                    Description = "Learn using ASP.NET",
                    CreatedOn = DateTime.Now.AddDays(-10),
                    OwnerId = this.GuestUser.Id,
                    BoardId = this.InProcessBoard.Id
                },
                 new Task()
                 {
                     Id = 4,
                     Title = "Prepare for C# Fundamentals",
                     Description = "Prepare by solving tasks",
                     CreatedOn = DateTime.Now.AddYears(-1),
                     OwnerId = this.GuestUser.Id,
                     BoardId = this.DoneBoard.Id
                 });

            base.OnModelCreating(builder);
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            this.GuestUser = new User()
            {
                UserName = "kresa05",
                NormalizedUserName = "GUEST",
                Email = "kresayuts@gmail.com",
                NormalizedEmail = "KRESAYUTS@GMAIL.COM",
                FirstName = "Kresa",
                LastName = "TSvetkova"
            };

            this.GuestUser.PasswordHash = hasher.HashPassword(this.GuestUser, "1111");
        }
        private void SeedBoards()
        {
            this.OpenBoard = new Board()
            {
                Id = 1,
                Name = "Open"
            };

            this.InProcessBoard = new Board
            {
                Id = 2,
                Name = "In Progress"
            };

            this.DoneBoard = new Board
            {
                Id = 3,
                Name = "Done"
            };
        }

    }
}
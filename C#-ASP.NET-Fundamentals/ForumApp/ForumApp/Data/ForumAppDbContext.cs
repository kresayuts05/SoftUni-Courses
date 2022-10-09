using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Post> Posts { get; init; }

        private Post FirstPost { get; set; }
        private Post SecondPost { get; set; }
        private Post ThirdPost { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>();

            SeedMethod();

            builder.Entity<Post>()
                .HasData(this.FirstPost,
                         this.SecondPost,
                         this.ThirdPost);

            base.OnModelCreating(builder);
        }

        private void SeedMethod()
        {
            this.FirstPost = new Post()
            {
                Id = 1,
                Title = "My first Post",
                Content = "My content 1 st post."
            };

            this.SecondPost = new Post()
            {
                Id = 2,
                Title = "My second Post",
                Content = "My content 2 st post."
            };

            this.ThirdPost = new Post()
            {
                Id = 3,
                Title = "My third Post",
                Content = "My content 3 st post."
            };
        }
    }
}

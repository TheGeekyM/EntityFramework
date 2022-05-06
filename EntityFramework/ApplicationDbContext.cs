using EntityFramework.Configurations;
using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = "Server=localhost;Database=.net;User=root;Password=";
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>(); // The third way to make your entity related to a table

            //Fluent API preferred on data annotation because of seperation of concern
            new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<Entities.User>());
            new PostEntityTypeConfiguration().Configure(modelBuilder.Entity<Post>());
        }
    }
}

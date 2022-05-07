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
            
            modelBuilder.Entity<AuditEntry>().ToTable("AuditEntry" , b => b.ExcludeFromMigrations()); // Don't update migration
                                                                                                      // if any updates happns on
                                                                                                      // this entity
            // Change type,add comments, Change Max Length and add defaults
            modelBuilder.Entity<AuditEntry>(ae =>
            {
                ae.Property(b => b.Description).HasColumnType("varchar(200)");
                ae.Property(b => b.Comment).HasMaxLength(200).HasComment("Add this comment to this column");
                ae.Property(b => b.Rating).HasColumnType("decimal(5,2)").HasDefaultValue(5);
                ae.Property(b => b.CreatedDate).HasDefaultValueSql("GETDATE()");
            });

            /** Primary Keys **/
            //Primary key - hasName is optional
            //modelBuilder.Entity<Book>().HasKey(b => b.BookKey).HasName("pk_bookKey");
            
            //To add composite key and it has to be done in flunt api only like this
            modelBuilder.Entity<Book>().HasKey(b => new {b.Name, b.BookKey });
            /** Primary Keys **/

            // Computed column 
            modelBuilder.Entity<Entities.User>().Property(b => b.DisplayedName)
                .HasComputedColumnSql("[FirstName] + ', ' + [LastName]");

            /** Primary Key Default Value - if we add an Id with a not int type like byte it will not be 
             auto generated so if we want to make it auto generated we will do this **/
            modelBuilder.Entity<AuditEntry>().Property(b => b.Id).ValueGeneratedOnAdd();


            //Fluent API preferred on data annotation because of seperation of concern
            new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<Entities.User>());
            new PostEntityTypeConfiguration().Configure(modelBuilder.Entity<Post>());
        }
    }
}

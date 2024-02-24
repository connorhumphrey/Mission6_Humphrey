using Microsoft.EntityFrameworkCore;

namespace Mission6_Humphrey.Models
{
    public class MovieFormContext1 : DbContext
    {
        public MovieFormContext1(DbContextOptions<MovieFormContext1> options) : base(options)
        {
        }

        public DbSet<Submission1> Movies { get; set; }
        public DbSet<MovieCategories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between Submission1 and MovieCategories
            modelBuilder.Entity<Submission1>().ToTable("Movies");
            modelBuilder.Entity<MovieCategories>().ToTable("Categories");

            modelBuilder.Entity<Submission1>()
                .HasOne(s => s.Category)               // Submission1 has one Category
                .WithMany(c => c.Submissions)           // Category has many Submissions
                .HasForeignKey(s => s.CategoryId);     // Foreign key is CategoryId in Submission1
        }
    }
}

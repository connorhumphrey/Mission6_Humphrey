using Microsoft.EntityFrameworkCore;

namespace Mission6_Humphrey.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) 
        {
        }

        public DbSet<Submission> Submissions { get; set; }
    }
}

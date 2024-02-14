using Microsoft.EntityFrameworkCore;

namespace JN_Mission6.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base (options) 
        { 
        }
        public DbSet<MovieSubmit> Applications { get; set; }
    }
}

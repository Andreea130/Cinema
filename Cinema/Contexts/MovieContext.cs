using Cinema.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Contexts
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}
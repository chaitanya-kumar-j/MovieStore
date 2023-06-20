using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Models;

namespace MovieStoreApp.Data
{
    public class MovieStoreAppDbContext : DbContext
    {
        public MovieStoreAppDbContext (DbContextOptions<MovieStoreAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}

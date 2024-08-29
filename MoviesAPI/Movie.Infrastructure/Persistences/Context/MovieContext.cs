using Microsoft.EntityFrameworkCore;
using Movie.Domain.Entities.Models;

namespace Movie.Infrastructure.Persistences.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        {
        }

        public MovieContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<MoviesSaved> MoviesSaved { get; set; }
    }
}

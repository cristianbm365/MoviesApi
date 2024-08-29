using Microsoft.EntityFrameworkCore;
using Movie.Domain.Entities;
using System.Reflection;

namespace Movie.Infrastructure.Persistences.Context;

public partial class MovieDatabaseContext : DbContext
{
    public MovieDatabaseContext()
    {
    }

    public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MoviesSaved> MoviesSaved { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Modern_English_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

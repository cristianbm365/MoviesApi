using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Domain.Entities;

namespace Movie.Infrastructure.Persistences.Context.Configurations
{
    public class MoviesSavedConfiguration : IEntityTypeConfiguration<MoviesSaved>
    {
        public void Configure(EntityTypeBuilder<MoviesSaved> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__MoviesSa__3214EC07447B53CD");

            builder.ToTable("MoviesSaved");

            builder.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.User).WithMany(p => p.MoviesSaveds)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MoviesSav__UserI__5DCAEF64");
        }
    }
}

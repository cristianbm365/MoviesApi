using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Domain.Entities;

namespace Movie.Infrastructure.Persistences.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CB220BCB0");

            builder.Property(e => e.Created).HasPrecision(0);
            builder.Property(e => e.Createdby).HasMaxLength(100);
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Modified).HasPrecision(0);
            builder.Property(e => e.Modifiedby).HasMaxLength(100);
            builder.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.Salt)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleId__5AEE82B9");
        }
    }
}

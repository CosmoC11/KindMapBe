using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.API.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("roles");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(e => e.Name).IsUnique();


            // Seed data with STATIC datetime
            //var seedDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            // Seed data
            builder.HasData(
                new Role { Id = 1, Name = "admin", Description = "Full system access" },
                new Role { Id = 2, Name = "moderator", Description = "Can verify and manage help points" },
                new Role { Id = 3, Name = "verified_user", Description = "Verified user with full features" },
                new Role { Id = 4, Name = "user", Description = "Basic user access" },
                new Role { Id = 5, Name = "guest", Description = "Limited read-only access" }
            );
        }
    }
}
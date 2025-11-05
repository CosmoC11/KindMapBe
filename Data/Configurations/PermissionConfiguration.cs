using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("permissions");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.Resource)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(e => e.Action)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.HasIndex(e => e.Name).IsUnique();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.ToTable("audit_logs");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Action)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.EntityType)
                .HasMaxLength(50);
            
            builder.HasIndex(e => e.UserId);
            builder.HasIndex(e => e.CreatedAt);
            
            // Relationships
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
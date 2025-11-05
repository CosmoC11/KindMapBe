using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("notifications");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Type)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(e => e.Title)
                .HasMaxLength(255)
                .IsRequired();
            
            builder.HasIndex(e => e.UserId);
            builder.HasIndex(e => new { e.UserId, e.IsRead });
            
            // Relationships
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
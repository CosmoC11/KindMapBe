using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class HelpResponseConfiguration : IEntityTypeConfiguration<HelpResponse>
    {
        public void Configure(EntityTypeBuilder<HelpResponse> builder)
        {
            builder.ToTable("help_responses");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.HasIndex(e => e.HelpPointId);
            builder.HasIndex(e => e.UserId);
            
            // Unique constraint: one response per user per help point
            builder.HasIndex(e => new { e.HelpPointId, e.UserId })
                .IsUnique();
            
            // Relationships
            builder.HasOne(e => e.HelpPoint)
                .WithMany(h => h.HelpResponses)
                .HasForeignKey(e => e.HelpPointId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
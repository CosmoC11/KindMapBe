using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.ToTable("reports");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(e => e.Reason)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.HasIndex(e => e.Status);
            
            // Relationships
            builder.HasOne(e => e.Reporter)
                .WithMany()
                .HasForeignKey(e => e.ReportedBy)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(e => e.Reviewer)
                .WithMany()
                .HasForeignKey(e => e.ReviewedBy)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.API.Data.Configurations
{
    public class HelpPointConfiguration : IEntityTypeConfiguration<HelpPoint>
    {
        public void Configure(EntityTypeBuilder<HelpPoint> builder)
        {
            builder.ToTable("help_points");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Title)
                .HasMaxLength(255)
                .IsRequired();
            
            builder.Property(e => e.Description)
                .IsRequired();
            
            builder.Property(e => e.Category)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(e => e.Subcategory)
                .HasMaxLength(100);
            
            builder.Property(e => e.UrgencyLevel)
                .HasMaxLength(20)
                .IsRequired();
            
            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(e => e.Latitude)
                .HasPrecision(10, 8);
            
            builder.Property(e => e.Longitude)
                .HasPrecision(11, 8);
            
            // Spatial index
            builder.HasIndex(e => e.Location)
                .HasMethod("GIST");
            
            builder.HasIndex(e => e.Status);
            builder.HasIndex(e => e.Category);
            builder.HasIndex(e => e.UrgencyLevel);
            builder.HasIndex(e => e.CreatedBy);
            
            // Relationships
            builder.HasOne(e => e.Creator)
                .WithMany(u => u.HelpPoints)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(e => e.AssignedUser)
                .WithMany()
                .HasForeignKey(e => e.AssignedTo)
                .OnDelete(DeleteBehavior.SetNull);
            
            builder.HasOne(e => e.Verifier)
                .WithMany()
                .HasForeignKey(e => e.VerifiedBy)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
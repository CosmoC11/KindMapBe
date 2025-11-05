using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class HelpPointImageConfiguration : IEntityTypeConfiguration<HelpPointImage>
    {
        public void Configure(EntityTypeBuilder<HelpPointImage> builder)
        {
            builder.ToTable("help_point_images");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsRequired();
            
            builder.Property(e => e.ThumbnailUrl)
                .HasMaxLength(500);
            
            builder.HasIndex(e => e.HelpPointId);
            
            // Relationships
            builder.HasOne(e => e.HelpPoint)
                .WithMany(h => h.Images)
                .HasForeignKey(e => e.HelpPointId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(e => e.Uploader)
                .WithMany()
                .HasForeignKey(e => e.UploadedBy)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
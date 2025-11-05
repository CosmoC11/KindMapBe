using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.API.Data.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("refresh_tokens");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Token)
                .HasMaxLength(500)
                .IsRequired();
            
            builder.HasIndex(e => e.UserId);
            builder.HasIndex(e => e.Token).IsUnique();
            
            // Relationships
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
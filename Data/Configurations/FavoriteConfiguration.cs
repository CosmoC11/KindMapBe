using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class UserFavoriteConfiguration : IEntityTypeConfiguration<UserFavorite>
    {
        public void Configure(EntityTypeBuilder<UserFavorite> builder)
        {
            builder.ToTable("user_favorites");
            builder.HasKey(e => new { e.UserId, e.HelpPointId });
            
            // Relationships
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(e => e.HelpPoint)
                .WithMany()
                .HasForeignKey(e => e.HelpPointId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
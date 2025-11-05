using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KindMap.Models.Entities;

namespace KindMap.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments");
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Content)
                .IsRequired();
            
            builder.HasIndex(e => e.HelpPointId);
            builder.HasIndex(e => e.UserId);
            
            // Relationships
            builder.HasOne(e => e.HelpPoint)
                .WithMany(h => h.Comments)
                .HasForeignKey(e => e.HelpPointId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // Self-referencing for replies
            builder.HasOne(e => e.ParentComment)
                .WithMany(c => c.Replies)
                .HasForeignKey(e => e.ParentCommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
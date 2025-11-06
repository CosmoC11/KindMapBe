namespace KindMap.Models.Entities
{
    public class UserFavorite
    {
        public Guid UserId { get; set; }
        public Guid HelpPointId { get; set; }
        public DateTime CreatedAt { get; set; } 
        
        // Navigation properties
        public User User { get; set; } = null!;
        public HelpPoint HelpPoint { get; set; } = null!;
    }
}
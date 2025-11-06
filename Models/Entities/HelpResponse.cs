namespace KindMap.Models.Entities
{
    public class HelpResponse
    {
        public Guid Id { get; set; } 
        public Guid HelpPointId { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; } = "interested";
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        
        // Navigation properties
        public HelpPoint HelpPoint { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
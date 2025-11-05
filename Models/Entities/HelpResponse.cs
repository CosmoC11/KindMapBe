namespace KindMap.Models.Entities
{
    public class HelpResponse
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid HelpPointId { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; } = "interested";
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public HelpPoint HelpPoint { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
namespace KindMap.Models.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Message { get; set; }
        public string? RelatedEntityType { get; set; }
        public Guid? RelatedEntityId { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } 
        // Navigation properties
        public User User { get; set; } = null!;
    }
}
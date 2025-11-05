namespace KindMap.Models.Entities
{
    public class HelpPointImage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid HelpPointId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string? ThumbnailUrl { get; set; }
        public bool IsPrimary { get; set; } = false;
        public Guid? UploadedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public HelpPoint HelpPoint { get; set; } = null!;
        public User? Uploader { get; set; }
    }
}
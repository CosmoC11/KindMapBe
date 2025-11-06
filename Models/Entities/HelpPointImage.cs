namespace KindMap.Models.Entities
{
    public class HelpPointImage
    {
        public Guid Id { get; set; }
        public Guid HelpPointId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string? ThumbnailUrl { get; set; }
        public bool IsPrimary { get; set; } = false;
        public Guid? UploadedBy { get; set; }
        public DateTime CreatedAt { get; set; } 
        
        // Navigation properties
        public HelpPoint HelpPoint { get; set; } = null!;
        public User? Uploader { get; set; }
    }
}
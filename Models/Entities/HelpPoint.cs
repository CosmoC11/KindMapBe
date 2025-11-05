using NetTopologySuite.Geometries;

namespace KindMap.Models.Entities
{
    public class HelpPoint
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Status { get; set; } = "active";
        
        public Point Location { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation
        public User Creator { get; set; } = null!;
        // public ICollection<HelpPointImage> Images { get; set; } = new List<HelpPointImage>();
    }
}
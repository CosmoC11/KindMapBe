using NetTopologySuite.Geometries;

namespace KindMap.Models.Entities
{
    public class HelpPoint
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string? Subcategory { get; set; }
        public string UrgencyLevel { get; set; } = "medium";
        public string Status { get; set; } = "active";
        
        // Geospatial
        public Point Location { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? Address { get; set; }
        
        // User references
        public Guid CreatedBy { get; set; }
        public Guid? AssignedTo { get; set; }
        
        // Verification
        public bool IsVerified { get; set; } = false;
        public Guid? VerifiedBy { get; set; }
        public DateTime? VerifiedAt { get; set; }
        
        // Metadata
        public int ViewCount { get; set; } = 0;
        public int HelpCount { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ResolvedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        
        // Navigation properties
        public User Creator { get; set; } = null!;
        public User? AssignedUser { get; set; }
        public User? Verifier { get; set; }
        public ICollection<HelpPointImage> Images { get; set; } = new List<HelpPointImage>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<HelpResponse> HelpResponses { get; set; } = new List<HelpResponse>();
    }
}
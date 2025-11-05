namespace KindMap.Models.Entities
{
    public class Report
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ReportedBy { get; set; }
        public string EntityType { get; set; } = null!;
        public Guid EntityId { get; set; }
        public string Reason { get; set; } = null!;
        public string? Description { get; set; }
        public string Status { get; set; } = "pending";
        public Guid? ReviewedBy { get; set; }
        public DateTime? ReviewedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public User Reporter { get; set; } = null!;
        public User? Reviewer { get; set; }
    }
}
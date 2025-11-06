using System.Net;

namespace KindMap.Models.Entities
{
    public class AuditLog
    {
        public Guid Id { get; set; } 
        public Guid? UserId { get; set; }
        public string Action { get; set; } = null!;
        public string? EntityType { get; set; }
        public Guid? EntityId { get; set; }
        public string? OldValues { get; set; } // JSON
        public string? NewValues { get; set; } // JSON
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public DateTime CreatedAt { get; set; }
        
        // Navigation properties
        public User? User { get; set; }
    }
}
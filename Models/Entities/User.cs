namespace KindMap.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? FullName { get; set; }
        public int RoleId { get; set; }
        public bool isVerified { get; set; } = false;
        public bool isActive { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties ?
        public Role Role { get; set; } = null!;
        // public ICollection<HelpPoint> HelpPoints { get; set; } = new List<HelpPoint>();

    }
}
namespace KindMap.Models.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Resource { get; set; } = null!;
        public string Action { get; set; } = null!;
        
        // Navigation properties
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
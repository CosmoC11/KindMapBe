using Microsoft.EntityFrameworkCore;
using KindMap.Models.Entities;

namespace KindMap.Data
{
    public class KindMapDbContext : DbContext
    {
        public KindMapDbContext(DbContextOptions<KindMapDbContext> options) 
            : base(options) { }

        // DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<HelpPoint> HelpPoints { get; set; }
        public DbSet<HelpPointImage> HelpPointImages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<HelpResponse> HelpResponses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Enable PostGIS extension
            modelBuilder.HasPostgresExtension("postgis");
            
            // Apply all configurations from the assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KindMapDbContext).Assembly);
        }
    }
}
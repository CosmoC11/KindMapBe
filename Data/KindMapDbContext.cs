using Microsoft.EntityFrameworkCore;
using KindMap.Models.Entities;

namespace KindMap.Data
{
    public class KindMapDbContext: DbContext
    {
        public KindMapDbContext(DbContextOptions<KindMapDbContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; } 
        public DbSet<HelpPoint> HelpPoints { get; set; }
        // public DbSet<HelpPointImage> HelpPointsImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KindMapDbContext).Assembly);
        }
    }
}
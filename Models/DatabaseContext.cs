using Microsoft.EntityFrameworkCore;
namespace CommunityResourceDB.Models
{
    public class CRContext : DbContext
    {
        public CRContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<FavoritesList> FavoritesLists { get; set; }

    }
}
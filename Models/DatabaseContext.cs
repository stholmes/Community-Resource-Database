using Microsoft.EntityFrameworkCore;
namespace CommunityResourceDB.Models
{
    public class CRContext : DbContext
    {
        public CRContext(DbContextOptions options) : base(options) { }

    }
}
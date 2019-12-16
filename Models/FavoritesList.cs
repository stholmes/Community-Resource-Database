using System;
using System.ComponentModel.DataAnnotations;

namespace CommunityResourceDB
{
    public class FavoritesList
    {
        [Key]
        public int ListId { get; set; }

        public int ResourceId { get; set; }

        public Resource Resource { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
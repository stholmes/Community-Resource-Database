using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CommunityResourceDB
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Website { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        public List<FavoritesList> UsersList { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



    }
}
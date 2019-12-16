using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunityResourceDB
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }


        [Required]
        public bool IsAdmin { get; set; } = false;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<FavoritesList> Favorites { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string NameToken { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BookClub.Models
{
    public class CategoryType
    {
        public int Category { get; set; }

        [Key]
        public int Type { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

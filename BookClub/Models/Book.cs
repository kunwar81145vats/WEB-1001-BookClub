
using System;
using System.ComponentModel.DataAnnotations;



namespace BookClub.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        public int CategoryId { get; set; } = 0;
        public string Author { get; set; }
    }
}
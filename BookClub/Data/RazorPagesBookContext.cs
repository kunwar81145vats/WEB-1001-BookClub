using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookClub.Models;

    public class RazorPagesBookContext : DbContext
    {
        public RazorPagesBookContext (DbContextOptions<RazorPagesBookContext> options)
            : base(options)
        {
        }

        public DbSet<BookClub.Models.Book> Book { get; set; }
        public DbSet<BookClub.Models.CategoryType> CategoryType { get; set; }
        public DbSet<BookClub.Models.Category> Category { get; set; }
}

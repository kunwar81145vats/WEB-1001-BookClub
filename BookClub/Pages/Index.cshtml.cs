using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookClub.Models;

namespace BookClub.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBookContext _context;

        public IndexModel(RazorPagesBookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; }
        public IList<CategoryType> CategoryTypes { get; set; }
        public IList<Category> Categories { get; set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
            CategoryTypes = await _context.CategoryType.ToListAsync();
            Categories = await _context.Category.ToListAsync();

        }
    }
}

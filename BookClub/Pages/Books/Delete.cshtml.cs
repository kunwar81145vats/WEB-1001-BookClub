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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesBookContext _context;

        public DeleteModel(RazorPagesBookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }
        public String CategoryType { get; set; }
        public String Category { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }

            CategoryType CategoryTypeObject = await _context.CategoryType.FirstOrDefaultAsync(m => m.Type == Book.CategoryId);
            Category CategoryObject = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == CategoryTypeObject.Category);
            Category = CategoryObject.NameToken;
            CategoryType = CategoryTypeObject.Name;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FindAsync(id);

            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Index");
        }
    }
}

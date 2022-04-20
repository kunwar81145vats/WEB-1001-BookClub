using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookClub.Models;

namespace BookClub.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBookContext _context;
        public IList<CategoryType> CategoryTypes { get; set; }

        public CreateModel(RazorPagesBookContext context)
        {
            _context = context;
        }

        //public IActionResult OnGet()
        //{
        //    return Page();
        //}

        public async Task OnGetAsync()
        {
            CategoryTypes = await _context.CategoryType.ToListAsync();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}

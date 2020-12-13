using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DatabaseHomework.Data;
using DatabaseHomework.Models;
using Microsoft.AspNetCore.Authorization;

namespace DatabaseHomework.Areas.Admin.Pages.AnimeGenres
{
    [Authorize(Policy = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public CreateModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AnimeID"] = new SelectList(_context.Animes, "ID", "Name");
        ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public AnimeGenre AnimeGenre { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AnimeGenres.Add(AnimeGenre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

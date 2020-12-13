using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatabaseHomework.Data;
using DatabaseHomework.Models;
using Microsoft.AspNetCore.Authorization;

namespace DatabaseHomework.Areas.Admin.Pages.AnimeGenres
{
    [Authorize(Policy = "Admin")]

    public class EditModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public EditModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AnimeGenre AnimeGenre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AnimeGenre = await _context.AnimeGenres
                .Include(a => a.Anime)
                .Include(a => a.Genre).FirstOrDefaultAsync(m => m.AnimeID == id);

            if (AnimeGenre == null)
            {
                return NotFound();
            }
           ViewData["AnimeID"] = new SelectList(_context.Animes, "ID", "Name");
           ViewData["GenreID"] = new SelectList(_context.Genres, "ID", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AnimeGenre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimeGenreExists(AnimeGenre.AnimeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AnimeGenreExists(int id)
        {
            return _context.AnimeGenres.Any(e => e.AnimeID == id);
        }
    }
}

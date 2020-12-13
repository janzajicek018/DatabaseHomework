using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DatabaseHomework.Data;
using DatabaseHomework.Models;
using Microsoft.AspNetCore.Authorization;

namespace DatabaseHomework.Areas.Admin.Pages.AnimeGenres
{
    [Authorize(Policy = "Admin")]

    public class DetailsModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public DetailsModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}

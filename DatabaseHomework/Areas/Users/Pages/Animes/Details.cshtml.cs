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

namespace DatabaseHomework.Areas.Users.Pages.Animes
{
    public class DetailsModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public DetailsModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Anime Anime { get; set; }
        public Anime Reviews { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Anime = await _context.Animes.Include(a => a.AnimeGenres)
                                         .ThenInclude(a => a.Genre)
                                         .AsNoTracking()
                                         .FirstOrDefaultAsync(m => m.ID == id);
            Reviews = await _context.Animes.Include(a => a.Reviews)
                                           .AsNoTracking()
                                           .FirstOrDefaultAsync(m => m.ID == id);

            if (Anime == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

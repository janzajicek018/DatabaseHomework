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

    public class IndexModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public IndexModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AnimeGenre> AnimeGenre { get;set; }

        public async Task OnGetAsync()
        {
            AnimeGenre = await _context.AnimeGenres
                .Include(a => a.Anime)
                .Include(a => a.Genre).ToListAsync();
        }
    }
}

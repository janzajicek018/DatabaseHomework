using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DatabaseHomework.Data;
using DatabaseHomework.Models;

namespace DatabaseHomework.Areas.Admin
{
    public class IndexModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public IndexModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Anime> Anime { get;set; }

        public async Task OnGetAsync()
        {
            Anime = await _context.Animes.ToListAsync();
        }
    }
}

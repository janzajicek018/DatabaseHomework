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
    public class DeleteModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public DeleteModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Anime Anime { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Anime = await _context.Animes.FirstOrDefaultAsync(m => m.ID == id);

            if (Anime == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Anime = await _context.Animes.FindAsync(id);

            if (Anime != null)
            {
                _context.Animes.Remove(Anime);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

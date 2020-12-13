using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DatabaseHomework.Data;
using DatabaseHomework.Models;
using System.Security.Claims;

namespace DatabaseHomework.Areas.Users.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;

        public CreateModel(DatabaseHomework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            ViewData["AnimeID"] = new SelectList(_context.Animes, "ID", "Name");
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            AnID = id;
            return Page();
        }

        [BindProperty]
        public Review Input { get; set; }
        [BindProperty]
        public int AnID { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;

            Review newReview = new Review
            {
                Mark = Input.Mark,
                Description = Input.Description,
                AnimeID = AnID,
                UserID = UserId
            };

            _context.Reviews.Add(newReview);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}

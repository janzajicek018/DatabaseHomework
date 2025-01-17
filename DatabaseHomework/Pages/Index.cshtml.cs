﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatabaseHomework.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DatabaseHomework.Data.ApplicationDbContext _context;


        public IndexModel(ILogger<IndexModel> logger, DatabaseHomework.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Anime> Anime { get; set; }
        public IEnumerable<Anime> Animes { get; set; }
        public async Task OnGetAsync()
        {
            Anime = await _context.Animes.ToListAsync();
            Animes = _context.Animes
               .Include(a => a.AnimeGenres).ThenInclude(a => a.Genre);
        }
    }
}

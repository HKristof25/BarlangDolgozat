using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarlangokD.Data;
using BarlangokD.Models;

namespace BarlangokD.Pages.Shared
{
    public class IndexModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public IndexModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<barlang> barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            barlang = await _context.barlangok.ToListAsync();
        }
    }
}

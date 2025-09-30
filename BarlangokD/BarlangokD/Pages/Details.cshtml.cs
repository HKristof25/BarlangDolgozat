using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarlangokD.Data;
using BarlangokD.Models;

namespace BarlangokD.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public DetailsModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public barlang barlang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barlang = await _context.barlangok.FirstOrDefaultAsync(m => m.id == id);
            if (barlang == null)
            {
                return NotFound();
            }
            else
            {
                barlang = barlang;
            }
            return Page();
        }
    }
}

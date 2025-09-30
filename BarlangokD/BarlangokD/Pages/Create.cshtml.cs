using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BarlangokD.Data;
using BarlangokD.Models;

namespace BarlangokD.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public CreateModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public barlang barlang { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.barlangok.Add(barlang);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

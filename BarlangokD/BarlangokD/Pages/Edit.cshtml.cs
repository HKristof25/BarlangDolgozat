using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarlangokD.Data;
using BarlangokD.Models;

namespace BarlangokD.Pages
{
    public class EditModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public EditModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public barlang barlang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barlang =  await _context.barlangok.FirstOrDefaultAsync(m => m.id == id);
            if (barlang == null)
            {
                return NotFound();
            }
            barlang = barlang;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(barlang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!barlangExists(barlang.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool barlangExists(int id)
        {
            return _context.barlangok.Any(e => e.id == id);
        }
    }
}

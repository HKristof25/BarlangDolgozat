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
    public class IndexModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public IndexModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string ValasztottTelepules { get; set; }

        public IList<string> Telepulesek {  get; set; }

        public IList<barlang> barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {

            Telepulesek = _context.barlangok.Select(x => x.telepules).Distinct().OrderBy(x => x).ToList();
            if(ValasztottTelepules == null)
            {
                barlang = await _context.barlangok.ToListAsync();
            }
   
            else
                barlang = await _context.barlangok.Where(x => x.telepules == ValasztottTelepules).ToListAsync();
        }
    }
}

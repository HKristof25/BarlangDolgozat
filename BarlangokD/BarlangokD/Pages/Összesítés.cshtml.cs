using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarlangokD.DIDs;
using BarlangokD.Data;

namespace BarlangokD.Pages
{
    public class ÖsszesítésModel : PageModel
    {
        private readonly BarlangokD.Data.BarlangDbContext _context;

        public ÖsszesítésModel(BarlangokD.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<BarlangAdatokDTO> BarlangAdatokDTO { get;set; } = default!;

        public async Task OnGet()
        {
            BarlangAdatokDTO = _context.barlangok.GroupBy(x => x.telepules).Select(y => new BarlangAdatokDTO
            {
                Telepules = y.Key,
                BarlangokSzama = y.Count()
            }).OrderByDescending(p => p.BarlangokSzama).ToList();
        }
    }
}

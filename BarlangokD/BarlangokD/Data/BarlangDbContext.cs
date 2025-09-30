using BarlangokD.Models;
using Microsoft.EntityFrameworkCore;
using BarlangokD.DIDs;

namespace BarlangokD.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {

        }
        public DbSet<barlang> barlangok {  get; set; }
        public DbSet<BarlangokD.DIDs.BarlangAdatokDTO> BarlangAdatokDTO { get; set; } = default!;
    }
}

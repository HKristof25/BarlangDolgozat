using BarlangokD.Models;
using Microsoft.EntityFrameworkCore;

namespace BarlangokD.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {

        }
        public DbSet<barlang> barlangok {  get; set; }
    }
}

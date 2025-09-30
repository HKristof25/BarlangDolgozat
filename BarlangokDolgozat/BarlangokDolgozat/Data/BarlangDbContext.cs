using BarlangokDolgozat.Models;
using Microsoft.EntityFrameworkCore;
namespace BarlangokDolgozat.Data
{
    public class BarlangDbContext: DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options) { }

        public DbSet<Barlang> Barlangok { get; set; }
    }
}

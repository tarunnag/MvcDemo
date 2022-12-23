using Microsoft.EntityFrameworkCore;
using MVCDemopractice.Models;

namespace MVCDemopractice.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Categorycs> categories { get; set; } 
    }
}

using E_commerceBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerceBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories{ get; set; }
    }
}

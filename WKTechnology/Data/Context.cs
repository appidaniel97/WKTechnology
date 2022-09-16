using Microsoft.EntityFrameworkCore;
using WKTechnology.Models;

namespace WKTechnology.Data
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) :base(options)
        {
            
        }
        public DbSet<Products> Products { get; set; }          
        public DbSet<Categories> Categories { get; set; }
    }
}

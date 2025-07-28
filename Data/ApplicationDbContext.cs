using Microsoft.EntityFrameworkCore;
using MVC_Refuerzo.Models;

namespace MVC_Refuerzo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
        public DbSet<Producto> Producto { get; set; }
    }
}

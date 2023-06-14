using FirstApiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApiApp.DAL
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        

        public DbSet<Group> Groups { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}

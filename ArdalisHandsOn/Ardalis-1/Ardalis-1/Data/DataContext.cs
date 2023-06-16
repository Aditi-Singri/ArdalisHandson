using Ardalis_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ardalis_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Hero> Heroes { get; set; }
    }
}

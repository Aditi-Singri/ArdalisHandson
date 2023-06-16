using Microsoft.EntityFrameworkCore;

namespace Ardalis_3.Data
{
    public class DataContext
    : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

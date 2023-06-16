using Ardalis_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ardalis_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Customers> Customers { get; set; }

    }
}

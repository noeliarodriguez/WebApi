using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
           // Database.SetCommandTimeout((int)TimeSpan.FromMinutes(1).TotalSeconds);
        }

        public DbSet<User> Users_Api { get; set; }
    }
}

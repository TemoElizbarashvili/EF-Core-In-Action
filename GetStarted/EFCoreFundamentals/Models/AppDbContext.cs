using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreFundamentals.Models
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server=(LocalDb)\\MSSQLLocalDB;Database=FundamentalsOfEFCore;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book>? Books { get; set; }
    }
}

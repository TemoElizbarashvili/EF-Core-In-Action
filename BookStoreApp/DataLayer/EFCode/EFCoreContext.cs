using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EFClasses;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EFCode
{
    public class EFCoreContext : DbContext
    {
        

        protected EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.BookId, x.AuthorId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

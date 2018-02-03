using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookRental.Models
{
    public class BookRentalDbContext : DbContext
    {
        public BookRentalDbContext (DbContextOptions<BookRentalDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookRental.Models.Author> Author { get; set; }
        public DbSet<BookRental.Models.Book> Book { get; set; }
    }
}

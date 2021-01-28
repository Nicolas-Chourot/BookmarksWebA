using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookmarksWebA.Models;

namespace BookmarksWebA.Data
{
    public class BookmarksWebAContext : DbContext
    {
        public BookmarksWebAContext (DbContextOptions<BookmarksWebAContext> options)
            : base(options)
        {
        }

        public DbSet<BookmarksWebA.Models.Bookmark> Bookmark { get; set; }
    }
}

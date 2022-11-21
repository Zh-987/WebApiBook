using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int releasedate { get; set; }
    }

    public class BookContext : DbContext
    {
        public DbSet <Book> book { get; set; }
    }
}
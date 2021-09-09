using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_shortener.Models;

namespace URL_shortener.Data.Migrations
{
    public class UserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Urlshortener;Integrated Security=True");
        }
        public DbSet<URL> Urlshortener { get; set; }
    }
}

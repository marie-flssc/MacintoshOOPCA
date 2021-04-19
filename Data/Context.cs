using System;
using Microsoft.EntityFrameworkCore;
using Macintosh_OOP.Models;
namespace Macintosh_OOP.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Account> Account { get; set; }
        //public object Account { get; internal set; }
    }
}

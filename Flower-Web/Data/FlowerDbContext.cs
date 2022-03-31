using Flower_Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Flower_Web.Data
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext() : base("name=MyConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}
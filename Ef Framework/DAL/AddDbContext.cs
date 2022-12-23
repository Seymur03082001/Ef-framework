using Ef_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Framework.DAL
{
    internal class AddDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=CA-R215-PC07\\SQLEXPRESS;database=PizzaMizza;Integrated security=true;trusted_connection=true;Encrypt=false;");
        }
        public DbSet<Pizza> Pizzas{ get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

    }
}

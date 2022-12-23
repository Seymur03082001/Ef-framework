using Ef_Framework.DAL;
using Ef_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Framework.Services
{
    internal class SizeService
    {
        public void Create(string name,double price)
        {
            Size size = new Size();
            size.Name = name;
            size.Price = price;

            using(AddDbContext dbContext = new AddDbContext())
            {
                dbContext.Add(size);
                dbContext.SaveChanges();
            }
        }
    }
}

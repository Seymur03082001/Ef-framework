using Ef_Framework.DAL;
using Ef_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Framework.Services
{
    internal class PizzaService
    {
        public void Create(string name)
        {
            Pizza pizza = new Pizza();
            pizza.Name = name;

            using(AddDbContext dbContext =new AddDbContext())
            {
                    dbContext.Add(pizza);
                    dbContext.SaveChanges();
            }
        }
    }
}

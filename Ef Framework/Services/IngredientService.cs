using Ef_Framework.DAL;
using Ef_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Framework.Services
{
    internal class IngredientService
    {
        public void Create(string name)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.Name = name;

            using(AddDbContext dbContext= new AddDbContext())
            {
                dbContext.Ingredients.Add(ingredient);
                dbContext.SaveChanges();
            }
        }
    }
}

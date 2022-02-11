using CoffeeHouse.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Data.Entity.Ingredients
{
    internal class Milk : IIngredient
    {
        public static int Count { get; set; }
    }
}

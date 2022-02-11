using CoffeeHouse.Data.Entity.Ingredients;
using CoffeeHouse.Data.Interface;

namespace CoffeeHouse.Data.Entity.Apparatus
{
    internal class Fridge : IApparatus
    {
        public Milk Milk { get; set; }
    }
}

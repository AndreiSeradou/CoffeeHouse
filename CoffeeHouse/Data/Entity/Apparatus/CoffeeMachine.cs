using CoffeeHouse.Data.Interface;
using CoffeeHouse.Data.Entity.Ingredients;
using CoffeeHouse.Data.Entity.Drinks;

namespace CoffeeHouse.Data.Entity.Apparatus
{
    internal class CoffeeMachine : IApparatus
    {
        public Americano PrepareAmericano()
        {
            if (CoffeeBeam.Count <= 0)
            {
                return null;
            }
            else
            {
                CoffeeBeam.Count--;
                return new Americano();
            }
        }

    }
}

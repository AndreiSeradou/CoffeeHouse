using CoffeeHouse.Data.Interface;
using CoffeeHouse.Data.Entity.Ingredients;
using CoffeeHouse.Data.Entity.Drinks;

namespace CoffeeHouse.Data.Entity.Apparatus
{
    internal class CappuccinoMachine : IApparatus
    {
        public Latte PrepareLatte()
        {
            if (Milk.Count <= 0 || Syrop.Count <= 0 || CoffeeBeam.Count <= 0)
            {
                return null;
            }
            else
            {
                Milk.Count--;
                Syrop.Count--;
                CoffeeBeam.Count--;
                return new Latte();
            }
        }

        public Cappuchino PrepareCappuchino()
        {
            if (Milk.Count <= 0 || CoffeeBeam.Count <= 0)
            {
                return null;
            }
            else
            {
                Milk.Count--;
                CoffeeBeam.Count--;
                return new Cappuchino();
            }
        }
    }
}

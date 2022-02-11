using CoffeeHouse.Data.Entity.Apparatus;
using CoffeeHouse.Data.Entity.Dessert;
using CoffeeHouse.Data.Entity.Drinks;
using CoffeeHouse.Data.Entity.Human;
using CoffeeHouse.Data.Entity.Ingredients;
using CoffeeHouse.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Data.Entity.CoffeeHouse
{
    internal class CoffeeHouse
    {
        public CoffeeHouse()
        {
            apparatuses = new List<IApparatus> { new CappuccinoMachine(), new Fridge(), new CoffeeMachine(), new CashRegister(), new CashRegister() };
            Workers = new List<Worker> { new Worker(), new Worker() };
            ingredients = new List<IIngredient> { new CoffeeBeam(), new Milk(), new Syrop() };
            Drinks = new List<IDrinks> { new Americano(), new Cappuchino(), new Latte() };
            Dessert = new List<IDessert> { new CheeseeCake(), new Napaleon(), new Teramisu() };
        }
        public List<IDessert> Dessert { get; set; }
        public List<IDrinks> Drinks { get; set; }
        public List<IApparatus> apparatuses { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Client> Clients { get; set; }
        public List<IIngredient> ingredients { get; set; }
        public int TimeOfWork { get; set; }
        public int PeriodComingClient { get; set; }
        public int Rate { get; set; }

    }
}

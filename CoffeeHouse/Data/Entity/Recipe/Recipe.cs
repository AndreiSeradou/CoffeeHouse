using CoffeeHouse.Data.Entity.Ingredients;
using CoffeeHouse.Data.Interface;
using System.Collections.Generic;

namespace CoffeeHouse.Data.Entity.Recipe
{
    internal class Recipe : IRecipe
    {
        public Recipe()
        {
            RecipeAmericano = new List<IIngredient> { new CoffeeBeam() };
            RecipeCappuchino = new List<IIngredient> { new CoffeeBeam(), new Milk() };
            RecipeLatte = new List<IIngredient> { new CoffeeBeam(), new Milk(), new Syrop() };
        }

        public List<IIngredient> RecipeAmericano { get; set; }
        public List<IIngredient> RecipeCappuchino { get; set; }
        public List<IIngredient> RecipeLatte { get; set; }
    }
}

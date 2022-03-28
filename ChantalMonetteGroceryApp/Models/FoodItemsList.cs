using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
   
namespace ChantalMonetteGroceryApp
{
    public class FoodItemsListBase
    {
        public IEnumerable<FoodItem> FoodItems { get; set; }

        public void LoadFoodItems()
        {
            FoodItem CocoPuffs = new FoodItem
            { ID = 1, quantity = 10, foodName = "Coco Puffs", department = "Cereal", typeOfFood = "sugary", origin = "USA" };

            FoodItem Cheerios = new FoodItem
            { ID = 2, quantity = 16, foodName = "Cheerios", department = "Cereal", typeOfFood = "healthy", origin = "USA" };

            FoodItem FrootLoops = new FoodItem
            { ID = 8, quantity = 13, foodName = "Froot Loops",  department = "Cereal", typeOfFood = "fruity", origin = "USA" };

            FoodItem ChipsAHoy = new FoodItem
            { ID = 3, quantity = 6, foodName = "Chips a-Hoy",  department = "Cookies", typeOfFood = "sugary", origin = "USA" };

            FoodItem TeddyGrahams = new FoodItem
            { ID = 4, quantity = 18, foodName = "Teddy Grahams",  department = "Cookies", typeOfFood = "sugary", origin = "Canada" };

            FoodItem Oreos = new FoodItem
            { ID = 5, quantity = 3, foodName = "Oreos",  department = "Cookies", typeOfFood = "sugary", origin = "USA" };

            FoodItem Milk = new FoodItem
            { ID = 6, quantity = 17, foodName = "Whole Milk",  department = "Dairy", typeOfFood = "fatty", origin = "Canada" };

            FoodItem Yogurt = new FoodItem
            { ID = 7, quantity = 15, foodName = "Banana Yogurt",  department = "Dairy", typeOfFood = "fruity", origin = "Greece" };


            List<FoodItem> Cereal = new List<FoodItem> { CocoPuffs, Cheerios, FrootLoops };
            List<FoodItem> Cookies = new List<FoodItem> { ChipsAHoy, TeddyGrahams, Oreos };
            List<FoodItem> Dairy = new List<FoodItem> { Milk, Yogurt };

        }

    }
}

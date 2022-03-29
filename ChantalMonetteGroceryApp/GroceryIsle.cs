using System.Collections.Generic;



// 8. Add another file called GroceryIsle.cs
// 9. In your GroceryIsle file, define a class with a list of FoodItems
    // an aisle name and aisle number
    
public class GroceryIsle 
{
    public List<FoodItem> listofFoodItem;
    public int aisleNumber { get; set; }
    public string aisleName { get; set; }

    public GroceryIsle()
    {
        listofFoodItem = new List<FoodItem>();    
    }

}   



// 6. Add a file to your app called FoodItem.cs
// 7. In the FoodItem file, define a class with at least 3 properties
    // plus the quantity property.

public class FoodItem
{
    public int ID { get; set; }
    public int quantity { get; set; }
    public string foodName { get; set; }
    public string department { get; set; }
    public string typeOfFood { get; set; }
    public string origin { get; set; }

    // 15. FoodItem Quantity Counter
    // 16. Do not allow the counter to go above 20 or below 0
    public void qtyIncrease()
    {
        if (quantity < 20)
            quantity++;
    }

    public void qtyDecrease()
    {
        if (quantity > 0)
            quantity--;
    }

}
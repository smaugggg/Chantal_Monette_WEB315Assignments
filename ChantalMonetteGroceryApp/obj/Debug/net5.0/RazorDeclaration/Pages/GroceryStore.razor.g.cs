// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChantalMonetteGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using ChantalMonetteGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\_Imports.razor"
using ChantalMonetteGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\Pages\GroceryStore.razor"
       
    // creates an instance of a fooditem for our form to bind to
    FoodItem NewFoodItem = new FoodItem();

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Chantal\OneDrive\Desktop\ST CLAIR\WEB315 ASP\Assignment2\Chantal_Monette_WEB315Assignments\ChantalMonetteGroceryApp\Pages\GroceryStore.razor"
       
    // 12. In your Grocery Store component add a List of GroceryIsles
    // 13. Add 3 Aisles to your GroceryStore.
    List<GroceryIsle> aisles = new List<GroceryIsle> 
    {
        new GroceryIsle { aisleNumber = 1, aisleName = "Cereal", listofFoodItem = Cereal },
        new GroceryIsle { aisleNumber = 2, aisleName = "Cookies", listofFoodItem = Cookies },
        new GroceryIsle { aisleNumber = 3, aisleName = "Dairy", listofFoodItem = Dairy }
    };

    // 13. Each Aisle should have at least 2 FoodItems
    List<FoodItem> Cereal = new List<FoodItem>() {
        new FoodItem { ID = 1, quantity = 10, foodName = "Coco Puffs", department = "Cereal", typeOfFood = "sugary", origin = "USA" },
        new FoodItem { ID = 2, quantity = 16, foodName = "Cheerios", department = "Cereal", typeOfFood = "healthy", origin = "USA" },
        new FoodItem { ID = 8, quantity = 13, foodName = "Froot Loops",  department = "Cereal", typeOfFood = "fruity", origin = "USA" }
    };
    List<FoodItem> Cookies = new List<FoodItem>() { 
        new FoodItem { ID = 3, quantity = 6, foodName = "Chips a-Hoy",  department = "Cookies", typeOfFood = "sugary", origin = "USA" },
        new FoodItem { ID = 4, quantity = 18, foodName = "Teddy Grahams",  department = "Cookies", typeOfFood = "sugary", origin = "Canada" },
        new FoodItem { ID = 5, quantity = 3, foodName = "Oreos",  department = "Cookies", typeOfFood = "sugary", origin = "USA" }
    };
    List<FoodItem> Dairy = new List<FoodItem>() { 
        new FoodItem { ID = 6, quantity = 17, foodName = "Whole Milk",  department = "Dairy", typeOfFood = "fatty", origin = "Canada" },
        new FoodItem { ID = 7, quantity = 15, foodName = "Banana Yogurt",  department = "Dairy", typeOfFood = "fruity", origin = "Greece" }
    };






#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

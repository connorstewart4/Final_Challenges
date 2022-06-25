using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class MenuPoco
{
    public MenuPoco(int mealNumber, string mealName, string description, string ingredients, decimal price)
    {
        MealNumber = mealNumber;
        MealName = mealName;
        Description = description;
        Ingredients = ingredients;
        Price = price;
    }
    public MenuPoco (){}

    public int MealNumber { get; set; }
    public string MealName { get; set; }
    public string Description { get; set; }
    public string Ingredients { get; set; }
    public decimal Price { get; set; }

}

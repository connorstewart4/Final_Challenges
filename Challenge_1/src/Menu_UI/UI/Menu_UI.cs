using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Menu_UI
    {
        MenuRepo _Mrepo = new MenuRepo();
        public void Run()
        {
            RunMenu();
        }
        public void RunMenu()
        {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("Please type in a choice for your function: \n Add \n List \n Delete");
             string Selection = Console.ReadLine().ToLower();
             if (Selection == "add")
             {
                MenuPoco newMealOrder = NewMenuPOCO();
                _Mrepo.AddObject(newMealOrder);
             }
             else if (Selection == "list")
             {
                 Console.Clear();
                 foreach (MenuPoco I in _Mrepo.GetMenuPocos())
                 {
                     System.Console.WriteLine($"{I.MealNumber} \n {I.MealName} \n {I.Description} \n {I.Ingredients} \n {I.Price}");
                 }
                 System.Console.WriteLine("Press Enter to continue...");
                 Console.Read();
             }
             else if (Selection == "delete")
             {
                 Console.Clear();
                 System.Console.WriteLine("Please enter the Meal Number you would like to remove: ");
                 int MealNumber = int.Parse(Console.ReadLine());
                 bool response = _Mrepo.RemoveObject(MealNumber);
                 if(response)
                 {
                 System.Console.WriteLine("The Meal Item has been removed! Please press enter to continue.");

                 }
                 else
                 {
                     System.Console.WriteLine("Meal Item was not removed.");
                 }
                 Console.Read();
             }

        }

        static MenuPoco NewMenuPOCO()
        {
            Console.Clear();
            Console.WriteLine("Please Enter the Meal Number:");
            int MealNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please Enter the Meal Name:");
            string MealName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please Enter the Meal Description:");
            string Description = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please Enter the Ingredients:");
            string Ingredients = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Price:");
            decimal Price = Decimal.Parse(Console.ReadLine());
            Console.Clear();

            
            Console.WriteLine("Menu Item has been created. Press Enter to Continue.");
            Console.Read();
            
            return new MenuPoco(MealNumber, MealName, Description, Ingredients, Price);
        }
            
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class MenuRepo
{
    private List<MenuPoco> MenuList = new List<MenuPoco>();

    public void AddObject(MenuPoco Adding)
    {
        MenuList.Add(Adding);
    }

    public void RemoveObject(int mealNumber)
    {
        MenuPoco folderToRemove = new MenuPoco(mealNumber, "", "", "", 0.0m);
        MenuList.Remove(folderToRemove);
    }

    public List<MenuPoco> GetMenuPocos()
    {
        return MenuList;
    }
}

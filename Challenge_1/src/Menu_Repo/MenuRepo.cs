using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class MenuRepo
{
    private readonly List<MenuPoco> _menuList = new List<MenuPoco>();

    public void AddObject(MenuPoco Adding)
    {
        _menuList.Add(Adding);
    }

    public bool RemoveObject(int mealNumber)
    {
        
        var menuItem = GetMenuByNumber(mealNumber);
        if(menuItem == null)
        {
            return false;
        }
        _menuList.Remove(menuItem); //needs loop
        return true;
    }

    public List<MenuPoco> GetMenuPocos()
    {
        return _menuList;
    }
    public MenuPoco GetMenuByNumber(int mealNumber)
    {
        foreach (MenuPoco m in _menuList)
        {
            if (mealNumber == m.MealNumber)
            {
                return m;
            }
        }
        return null;
    }
}

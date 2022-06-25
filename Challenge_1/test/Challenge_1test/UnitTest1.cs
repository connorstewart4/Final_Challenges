using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Challenge_1test;

public class UnitTest1
{
    private MenuRepo _testingRepo = new MenuRepo();

    [Fact]
    public void Test1()
    {
       
       _testingRepo.AddObject(new MenuPoco(1, "test", "", "", 2.50m));
    }

    [Fact]
    public void MenuRepo_GetList()
    {
       
        MenuPoco item1 = new MenuPoco(1, "test1", "", "", 2.50m);
        MenuPoco item2 = new MenuPoco(2, "test2", "", "", 2.50m);
        _testingRepo.AddObject(item1);
        _testingRepo.AddObject(item2);

        int expectedMenuCount = 2;
        int actualCount = _testingRepo.GetMenuPocos().Count();

        Assert.Equal(expectedMenuCount, actualCount);
    }

    [Fact]
    public void AddMenuItem()
    {
        _testingRepo.AddObject(new MenuPoco(1, "test", "", "", 2.5m));
    
        Assert.Equal(1, _testingRepo.GetMenuPocos().Count());
    }
    
    [Fact]
    public void DeleteMenuItem()
    {
        _testingRepo.RemoveObject(1);

        Assert.Equal(0, _testingRepo.GetMenuPocos().Count());
    }
}
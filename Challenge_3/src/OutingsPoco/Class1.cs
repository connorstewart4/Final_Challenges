using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Outings
{
    public enum OutingType
    {
        Golf = 1,
        Bowling,
        AmusementPark,
        Concert
    }

    public Outings(int type, DateTime date, decimal costEach, int headCount)
    {
        
        Type = (OutingType)type;
        Date = date;
        CostEach = costEach;
        Headcount = headCount;
        TotalCost = costEach * headCount;
    }

    public Enum Type { get; set; }
    public DateTime Date { get; set; }
    public decimal CostEach { get; set; }
    public int Headcount { get; set; }
    public decimal TotalCost { get; set; }
}

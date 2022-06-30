using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class OutingsRepo
{
    private List<Outings> OutingsList = new List<Outings>();

    public void AddOuting(Outings outing)
    {
        OutingsList.Add(outing);
    }

    public List<Outings> GetAllOutings()
    {
        return OutingsList;
    }

    public List<Outings> GetOutingsByType(int type)
    {
        List<Outings> OutingsByType = new List<Outings>();
        foreach (Outings o in OutingsList)
        {
            if (Convert.ToInt32(o.Type) == type)
            {
                OutingsByType.Add(o);
            }
        }
        return OutingsByType;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class ClaimRepo
{
    private Queue<Claims> ClaimsList = new Queue<Claims>();
    private int AllClaims = 0;

    public void AddClaim(Claims claim)
    {
        AllClaims++;
        claim.ClaimID = AllClaims;
        ClaimsList.Enqueue(claim);
    }

    public Claims GetNextClaim()
    {
        return ClaimsList.Peek();
    }

    public void Dequeue()
    {
        ClaimsList.Dequeue();
    }

    public List<Claims> GetListOfClaims()
    {
        return ClaimsList.ToList();
    }
}

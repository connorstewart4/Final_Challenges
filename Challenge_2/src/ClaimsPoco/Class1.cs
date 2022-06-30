using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Claims
{
    private enum ClaimTypes
    {
        House = 1,
        Car,
        Theft
    }

    public Claims(int claimType,  string description, decimal claimAmount, DateTime accidentDate, DateTime claimDate)
    {
        ClaimType = (ClaimTypes)claimType;
        Description = description;
        ClaimAmount = claimAmount;
        AccidentDate = accidentDate.Date.ToString("d");
        ClaimDate = claimDate.Date.ToString("d");
        IsValid = (claimDate - accidentDate).TotalDays <=30;
    }

    public int ClaimID { get; set; }
    public Enum ClaimType { get; set; }
    public string Description { get; set; }
    public decimal ClaimAmount { get; set; }
    public string AccidentDate { get; set; }
    public string ClaimDate { get; set; }
    public bool IsValid { get; set; }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Claims_UI
    {
        ClaimRepo _cRepo = new ClaimRepo();
        public void Run()
        {
            RunMenu();
        }

        public void RunMenu()
        {
            _cRepo.AddClaim(new Claims(1, "House fire in kitchen", 400.00m, DateTime.Now, DateTime.Now));
            while (true)
            {
                Console.Clear();
                System.Console.WriteLine("Choose an Item: \n 1. See all claims. \n 2. Take care of next claim. \n 3. Enter a new claim. \n 4. Close");
                string Command = Console.ReadLine();
                if (Command == "1")
                {
                    DisplaySetup();
                    int row = 1;
                    List<Claims> ListOfClaims = _cRepo.GetListOfClaims();
                    foreach (Claims claim in ListOfClaims)
                    {
                        DisplayClaimInRow(claim, row);
                        row++;
                    }
                    Console.Read();
                }

                else if (Command == "2")
                {
                    Claims peekingClaim = _cRepo.GetNextClaim();
                    Console.Clear();
                    Console.WriteLine("Here are the details for the next claim to be updated: \n" +
                        $"ClaimID: {peekingClaim.ClaimID} \n" +
                        $"Type: {peekingClaim.ClaimType} \n" +
                        $"Description: {peekingClaim.Description} \n" +
                        $"Amount: ${peekingClaim.ClaimAmount} \n" +
                        $"DateOfClaim: {peekingClaim.ClaimDate} \n" +
                        $"DateOfAccident: {peekingClaim.AccidentDate} \n" +
                        $"IsValid: {peekingClaim.IsValid}"
                        );

                    Console.WriteLine("Do you want to Update this claim now? Y/N");
                    string yn = Console.ReadLine().ToLower();
                    if (yn == "y")
                    {
                        _cRepo.Dequeue();
                        _cRepo.AddClaim(newClaim());
                    }
                    else if (yn == "n")
                    {

                    }
                }
                else if (Command == "3")
                {
                    _cRepo.AddClaim(newClaim());
                }
                else if (Command == "4")
                {
                    break;
                }

            }
        }

        static Claims newClaim()
        {
            Console.Clear();
            Console.WriteLine("Enter the claim type car/house/theft:");
            string claimType = Console.ReadLine().ToLower();
            int ClaimType;
            switch (claimType)
            {
                case "car":
                    ClaimType = 2;
                    break;
                case "house":
                    ClaimType = 1;
                    break;
                case "theft":
                    ClaimType = 3;
                    break;
                default:
                    ClaimType = 0;
                    break;
            }
            Console.Clear();

            Console.WriteLine("Enter a claim description");
            string Description = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Amount of Damage:");
            decimal Amount = Decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Date of Accident (m/d/y):");
            string[] accidentDate = Console.ReadLine().Split('/');
            DateTime DateOfAccident = new DateTime(Int32.Parse(accidentDate[2]), Int32.Parse(accidentDate[0]), Int32.Parse(accidentDate[1]));
            Console.Clear();

            Console.WriteLine("Date of Claim (m/d/y):");
            string[] claimDate = Console.ReadLine().Split('/');
            DateTime DateOfClaim = new DateTime(Int32.Parse(claimDate[2]), Int32.Parse(claimDate[0]), Int32.Parse(claimDate[1]));
            Console.Clear();

            return new Claims(ClaimType, Description, Amount, DateOfAccident, DateOfClaim);
        }

        static void DisplayClaimInRow(Claims displayClaim, int row)
        {
            Console.SetCursorPosition(0, row);
            Console.Write(displayClaim.ClaimID);
            Console.SetCursorPosition(10, row);
            Console.Write(displayClaim.ClaimType);
            Console.SetCursorPosition(25, row);
            Console.Write(displayClaim.Description);
            Console.SetCursorPosition(55, row);
            Console.Write(displayClaim.ClaimAmount);
            Console.SetCursorPosition(65, row);
            Console.Write(displayClaim.AccidentDate);
            Console.SetCursorPosition(85, row);
            Console.Write(displayClaim.ClaimDate);
            Console.SetCursorPosition(100, row);
            Console.Write(displayClaim.IsValid);
        }

        static void DisplaySetup()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("ClaimID");
            Console.SetCursorPosition(10, 0);
            Console.Write("ClaimType");
            Console.SetCursorPosition(25, 0);
            Console.Write("Description");
            Console.SetCursorPosition(55, 0);
            Console.Write("Amount");
            Console.SetCursorPosition(65, 0);
            Console.Write("Accident Date");
            Console.SetCursorPosition(85, 0);
            Console.Write("Claim Date");
            Console.SetCursorPosition(100, 0);
            Console.Write("IsValid");
        }
    }

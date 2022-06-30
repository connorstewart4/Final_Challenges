using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Outings_UI
    {
        OutingsRepo _oRepo = new OutingsRepo();
        public void Run()
        {
            RunApplication();
        }

        public void RunApplication()
        {
            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("Komodo Outings \n" +
                "1. Add New Outing \n" +
                "2. List All Outings \n" +
                "3. List Outings By Type"
                );
                string Input = Console.ReadLine();
                switch(Input)
                {
                    case "1":
                    Console.Clear();
                    _oRepo.AddOuting(newOuting());
                    break;

                    case "2":
                    Console.Clear();
                    decimal totalCost = 0.00m;
                    foreach(Outings o in _oRepo.GetAllOutings())
                    {
                        totalCost = totalCost + o.TotalCost;
                        System.Console.WriteLine($"{o.Type}, {o.Date.ToShortDateString()} {o.Headcount} people which totals to ${o.TotalCost}");
                    }
                    System.Console.WriteLine($"The total cost for all outings is ${totalCost}");
                    System.Console.WriteLine("\nPress enter to continue.");
                    Console.Read();
                    break;

                    case "3":
                    Console.Clear();
                    System.Console.WriteLine("What type of outing? (golf, bowling, amusement park, or concert?");
                    int outingType;
                    switch(Console.ReadLine().ToLower())
                    {
                        case "golf":
                        outingType = 1;
                        break;

                        case "bowling":
                        outingType = 2;
                        break;

                        case "amusement park":
                        outingType = 3;
                        break;

                        case "concert":
                        outingType = 4;
                        break;

                        default:
                        outingType = 1;
                        break;
                    }
                    Console.Clear();
                    decimal TotalCost = 0.00m;
                    foreach (Outings o in _oRepo.GetOutingsByType(outingType))
                    {
                        TotalCost = TotalCost + o.TotalCost;
                        System.Console.WriteLine($"{o.Type}, {o.Date.ToShortDateString()}, {o.Headcount} people totaling ${o.TotalCost}");
                    }
                    System.Console.WriteLine($"The total cost for this type is ${TotalCost}");
                    System.Console.WriteLine("\nPress Enter to continue.");
                    Console.Read();
                    break;
                    default:
                    break;
                }
            }
        }

        static Outings newOuting()
        {
            System.Console.WriteLine("Type of outing (golf/bowling/amusement park/ concert:");
            int outingType;
            switch(Console.ReadLine().ToLower())
            {
                case "golf":
                outingType = 1;
                break;

                case "bowling":
                outingType = 2;
                break;

                case "amusement park":
                outingType = 3;
                break;

                case "concert":
                outingType = 4;
                break;

                default:
                outingType = 1;
                break;
            }

            Console.Clear();
            System.Console.WriteLine("Date of Outing (m/d/y):");
            string[] accidentDate = Console.ReadLine().Split('/');
            DateTime outingDate = new DateTime(int.Parse(accidentDate[2]), int.Parse(accidentDate[0]), int.Parse(accidentDate[1]));
            Console.Clear();

            System.Console.WriteLine("cost per person:");
            decimal costPerPerson = decimal.Parse(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine("How many people attended:");
            int headCount = int.Parse(Console.ReadLine());

            return new Outings(outingType, outingDate, costPerPerson, headCount);
        }
    }

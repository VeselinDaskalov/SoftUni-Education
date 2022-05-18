using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorCyclists = int.Parse(Console.ReadLine());
            int seniorCyclists = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();
            double juniorsTaksa = 0.00;
            double seniorsTaaksa = 0.00;
            double gatheredMoney = 0.00;
            double costs = gatheredMoney - (5.00 / 100.00 * gatheredMoney);
            double totalEverything = 0.00;
            int allParticipants = juniorCyclists + seniorCyclists;
            switch (traceType)
            {
                case "trail":
                    juniorsTaksa += 5.50;
                    seniorsTaaksa += 7.00;
                    gatheredMoney = ((juniorCyclists * juniorsTaksa) + (seniorCyclists * seniorsTaaksa));
                    costs = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - costs;
                    break;
                case ("cross-country"):
                    juniorsTaksa += 8.00;
                    seniorsTaaksa += 9.50;
                    gatheredMoney = ((juniorCyclists * juniorsTaksa) + (seniorCyclists * seniorsTaaksa));
                    costs = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - costs;
                    if (allParticipants >= 50.00)
                    {
                        totalEverything = (totalEverything - (25.00 / 100.00 * totalEverything));
                    }
                    break;
                case ("downhill"):
                    juniorsTaksa += 12.25;
                    seniorsTaaksa += 13.75;
                    gatheredMoney = ((juniorCyclists * juniorsTaksa) + (seniorCyclists * seniorsTaaksa));
                    costs = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - costs;
                    break;
                case ("road"):
                    juniorsTaksa += 20.00;
                    seniorsTaaksa += 21.50;
                    gatheredMoney = ((juniorCyclists * juniorsTaksa) + (seniorCyclists * seniorsTaaksa));
                    costs = (5.00 / 100.00 * gatheredMoney);
                    totalEverything = gatheredMoney - costs;
                    break;
            }
            Console.WriteLine("{0:f2}", totalEverything);
        }
    }
}

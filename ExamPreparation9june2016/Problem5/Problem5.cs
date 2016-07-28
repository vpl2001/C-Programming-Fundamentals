using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem5
{
    static void Main(string[] args)
    {


    decimal numberFlights = int.Parse(Console.ReadLine());
    decimal overallProfit = 0;

        List<string> output = new List<string>();   
        for (int i = 1; i <= numberFlights; i++)
        {
            decimal adultPassangers = decimal.Parse(Console.ReadLine());
            decimal adaultTicketPrice = decimal.Parse(Console.ReadLine());
            decimal youthPassangers = decimal.Parse(Console.ReadLine());
            decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPriceHour = decimal.Parse(Console.ReadLine());
            decimal fuelConsumeHour = decimal.Parse(Console.ReadLine());
            decimal flightDuration = decimal.Parse(Console.ReadLine());

            decimal income = adultPassangers * adaultTicketPrice + youthPassangers * youthTicketPrice;
            decimal expenses = fuelPriceHour * fuelConsumeHour * flightDuration;

            if (income >= expenses)
            {
                decimal result = (income - expenses);
                string info = "You are ahead with " + result.ToString("0.000") + "$.";
                output.Add(info);
                overallProfit += (income - expenses);
            }
            else
            {

                decimal result = (income - expenses);
                string info = "We've got to sell more tickets! We've lost " + result.ToString("0.000") +"$.";
                output.Add(info);
                overallProfit += (income - expenses);
            }
        }

        Console.WriteLine(string.Join("\n", output));
        Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
        Console.WriteLine("Average profit -> {0:f3}$.",(overallProfit/numberFlights));
}
}

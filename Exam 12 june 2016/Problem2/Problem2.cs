using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Problem2
{
    static void Main(string[] args)
    {
        
        int orders = int.Parse(Console.ReadLine());
        decimal pricePerCapsule = decimal.MinValue;
        string orderDate = "";
        long capsulesCount = long.MinValue;
        decimal price = 0;
        decimal totalPrice = 0;
        var output = new List<decimal>();
        for (int i = 1; i <= orders; i++)
        {
            pricePerCapsule = decimal.Parse(Console.ReadLine());
            orderDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(orderDate, "d/M/yyyy", CultureInfo.InvariantCulture); ;
            capsulesCount = long.Parse(Console.ReadLine());

            var month = date.Month;
            var year = date.Year;

            var totalMonths = System.DateTime.DaysInMonth(year, month);
           
            price = ((totalMonths * capsulesCount) * pricePerCapsule);
            output.Add(price);
            totalPrice += price;
        }
        for (int i = 0; i < output.Count; i++)
        {
            Console.WriteLine("The price for the coffee is: ${0:f2}", output[i]);
        }
        Console.WriteLine("Total: ${0:f2}", totalPrice);
    }
}

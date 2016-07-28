using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double cashAmount = double.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        double bananaPrice = double.Parse(Console.ReadLine());
        double eggsPrice = double.Parse(Console.ReadLine());
        double berriesPrice = double.Parse(Console.ReadLine());

        double portionPrice = 2 * bananaPrice + 4 * eggsPrice + berriesPrice * 0.2;
        double allPortions = 0;

        if (guests %6 > 0)
        {
            allPortions = (guests / 6 + 1) * portionPrice;
        }
        else if (guests==0)
        {
            allPortions = 0;
        }
        else
        {
            {
                allPortions = (guests / 6) * portionPrice;
            }
        }

        if (allPortions <= cashAmount)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", allPortions);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", allPortions-cashAmount);
        }
    }

}

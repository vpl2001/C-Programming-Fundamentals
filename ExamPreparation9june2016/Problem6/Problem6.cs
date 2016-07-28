using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problem6
    {
        static void Main(string[] args)
        {
        double totalWater = double.Parse(Console.ReadLine());
        var arrayBottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        long bottleCapacity = long.Parse(Console.ReadLine());
        double currentWater = totalWater;
        if (totalWater%2==0)
        {
            int index = 0;
            for (int i = 0; i < arrayBottles.Length; i++)
            {
               currentWater -= (bottleCapacity - arrayBottles[i]);
               index = i;
                if (currentWater < bottleCapacity)
                {
                    break;
                }
            }
            if (currentWater<=bottleCapacity)
            {
                List<int> indexes = new List<int>();
                for (int k = 0; k <index ; k++)
                {
                    indexes.Add(k);
                }
                
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", arrayBottles.Length-index-1);
                Console.WriteLine("With indexes: " + string.Join(", ", indexes));
                Console.WriteLine("We need {0}more liters!", Math.Abs(currentWater));
            }
            else
            {
               Console.WriteLine("Enough water!");
               Console.WriteLine("Water left: {0}l.", currentWater);
            }
        }
        else
        {
            int index = 0;
            for (int i = arrayBottles.Length-1; i >=0 ; i--)
            {
                currentWater -= (bottleCapacity - arrayBottles[i]);
                index = i;
                if (currentWater < bottleCapacity)
                {
                    break;
                }
            }
            if (currentWater < bottleCapacity)
            {
                List<int> indexes = new List<int>();
                for (int k = index; k >=0 ; k--)
                {
                    indexes.Add(k);
                }

                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", arrayBottles.Length - index);
                Console.WriteLine("With indexes: " + string.Join(", ", indexes));
                double ccc = Math.Abs(totalWater - ((index+1) * bottleCapacity + bottleCapacity));
                for (int i = 0; i < index-1; i++)
                {
                    ccc += (bottleCapacity- arrayBottles[i]);
                }
                Console.WriteLine("We need {0} more liters!", ccc);
            }
            else

            {
                Console.WriteLine("Enough water!");

                Console.WriteLine("Water left: {0}l.", totalWater);
            }
        }
        
    }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercises_18
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        PrintNumbersInList(FindPrimesInRange(startNum, endNum));

    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {


        List<int> Primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            int divider = 2;
            bool isPrime = true;

            if (i == 0 || i == 1)
            {
                isPrime = false;
            }

            while (isPrime && divider <= Math.Sqrt(i))
            {
                if (i % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
            if (isPrime)
            {
                Primes.Add(i);
            }
        }
        return Primes;
    }

    static void PrintNumbersInList(List<int> PrimesList)
    {
       
        Console.Write(string.Join(", ", PrimesList));
        Console.WriteLine();
    }
}

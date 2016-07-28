using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem2
    {
        static void Main(string[] args)
        {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(numbers);
        int counter = 0;
        for (int i = 1; i < numbers.Length-1; i++)
        {
            if (numbers[i-1]==numbers[i])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
        }
    }

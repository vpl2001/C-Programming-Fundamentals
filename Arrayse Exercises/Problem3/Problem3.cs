using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem3
    {
        static void Main(string[] args)
        {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int[] sum = new int[input.Length];

        for (int i = 1; i <= k; i++)
        {
            int lastIndex = input[input.Length-1];

            for (int r = input.Length - 1; r > 0 ; r--)
            {
                input[r] = input[r - 1];
            }

            input[0] = lastIndex;

            for (int r = 0; r < input.Length; r++)
            {
                sum[r] += input[r];
            }
        }
        Console.WriteLine(string.Join(" ", sum));
        }
    }

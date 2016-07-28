using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem4
    {
        static void Main(string[] args)
        {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int len = 1;
        int number = input[0];
        int bestLen = 1;

        for (int i = 0; i < input.Length-1; i++)
        {
           
            if (input[i]==input[i+1])
            {
                len++;

                if (len>bestLen)
                {
                    bestLen = len;
                    number = input[i];
                }               
            }
            else
            {
                len = 1;

            }

        }
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

    }
    }

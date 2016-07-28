using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem10
    {
        static void Main(string[] args)
        {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = input.Length / 4;

        int[] middleElements = new int[2*k];
        int[] firstElements = new int[k];
        int[] lastElements = new int[k];
        int[] firstAndLastElements = new int[2 * k];

        for (int i = 0; i < middleElements.Length; i++)
        {
            middleElements[i] = input[i + k];
        }
        for (int i = 0; i < firstElements.Length; i++)
        {
            firstElements[i] = input[i];
        }
        for (int i = 0; i < lastElements.Length; i++)
        {
            lastElements[i] = input[i + 3 * k];
        }

        Array.Reverse(firstElements);
        Array.Reverse(lastElements);

        for (int i = 0; i < firstAndLastElements.Length; i++)
        {
            if (i<k)
            {
                firstAndLastElements[i] = firstElements[i];
            }
            else
            {
                firstAndLastElements[i] = lastElements[i-k];
            }
        }

        for (int i = 0; i < middleElements.Length; i++)
        {
            middleElements[i] += firstAndLastElements[i];
        }

        Console.WriteLine(string.Join(" ", middleElements));
        }
    }

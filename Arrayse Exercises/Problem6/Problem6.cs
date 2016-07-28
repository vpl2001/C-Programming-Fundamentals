using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem6
    {
        static void Main(string[] args)
        {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isFound = false;

        for (int i = 0; i < input.Length; i++)
        {
            int sumLeft = 0;
            int sumRight = 0;

            for (int y = 0; y < i; y++)
            {
                sumLeft += input[y];
            }
            for (int w = i+1; w < input.Length; w++)
            {
                sumRight += input[w];
            }
            if (sumLeft==sumRight)
            {
                Console.WriteLine(i);
                isFound = true;
                break;
            } 
        }
        if (!isFound)
        {
            Console.WriteLine("no");
        }
    }
}

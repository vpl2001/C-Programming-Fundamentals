using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem9
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int a = i+1; a < input.Length; a++)
            {
                if (number == Math.Abs(input[i] - input[a]))
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

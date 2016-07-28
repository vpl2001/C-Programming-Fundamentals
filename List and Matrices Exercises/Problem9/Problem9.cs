using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem9
    {
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        int[] route = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int sum = matrix[0][route[0]];

        for (int i = 0; i < route.Length-1; i++)
        {
            sum += matrix[route[i]][route[i+1]];
        }
        Console.WriteLine(sum);
    }
    }

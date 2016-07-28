using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem3
    {
        static void Main(string[] args)
        {
        var n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];

        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        int primarySum = 0;
        int secondarySum = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            primarySum += matrix[i][i];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            secondarySum += matrix[i][n-1-i];
        }

        Console.WriteLine(Math.Abs(primarySum-secondarySum));
        }
    }